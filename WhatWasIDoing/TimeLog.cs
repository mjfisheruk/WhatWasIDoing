using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatWasIDoing
{
    class TimeLog
    {
        private String baseDirectory;

        public TimeLog(String baseDirectory)
        {
            this.baseDirectory = baseDirectory;
        }

        public bool HasLastEntry
        {
            get
            {
                return EntriesToday().Count != 0;
            }
        }

        public LogEntry LastEntry
        {
            get
            {
                return EntriesToday().Last();
            }
        }

        public void SaveEntry(String text)
        {
            SaveEntry(new LogEntry(text));
        }
        
        public void SaveEntry(LogEntry entry)
        {
            String dir = EntryDirectory(entry.Time);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            String path = EntryPath(entry.Time);
            TextWriter writer = File.AppendText(path);
            writer.WriteLine(entry.ToString());
            writer.Close();
        }

        public void LogStartup()
        {
            SaveEntry("[Startup]");
        }
        
        public void LogShutdown()
        {
            SaveEntry("[Shutdown]");
        }

        private string EntryDirectory(DateTime dateTime)
        {
            var year = dateTime.ToString("yyyy");
            var month = dateTime.ToString("MMM");
            return baseDirectory + "\\" + year + "\\" + month;
        }

        private string EntryPath(DateTime dateTime)
        {
            return EntryDirectory(dateTime) + "\\" + dateTime.ToString("yyyy-MM-dd") + ".txt";
        }

        private List<LogEntry> EntriesToday()
        {
            var result = new List<LogEntry>();
                
            String path = EntryPath(DateTime.Now);
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    result.Add(LogEntry.FromString(line, DateTime.Now.Date));
                }
            }

            return result;
        }
    }
}
