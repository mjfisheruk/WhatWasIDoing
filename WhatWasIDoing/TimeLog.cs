using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatWasIDoing
{
    class TimeLog
    {
        String baseDirectory;

        public bool HasLastEntry
        {
            get
            {
                return entriesToday().Count != 0;
            }
        }

        public LogEntry LastEntry
        {
            get
            {
                return entriesToday().Last();
            }
        }

        public TimeLog(String baseDirectory)
        {
            this.baseDirectory = baseDirectory;
        }

        public void SaveEntry(String text)
        {
            SaveEntry(new LogEntry(text));
        }
        
        public void SaveEntry(LogEntry entry)
        {
            String dir = entryDirectory(entry.Time);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            String path = entryPath(entry.Time);
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

        private string entryDirectory(DateTime dateTime)
        {
            var year = dateTime.ToString("yyyy");
            var month = dateTime.ToString("MMM");
            return baseDirectory + "\\" + year + "\\" + month;
        }

        private string entryPath(DateTime dateTime)
        {
            return entryDirectory(dateTime) + "\\" + dateTime.ToString("yyyy-MM-dd") + ".txt";
        }

        private List<LogEntry> entriesToday()
        {
            var result = new List<LogEntry>();
                
            String path = entryPath(DateTime.Now);
            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                result.Add(LogEntry.FromString(line, DateTime.Now.Date));
            }

            return result;
        }
    }
}
