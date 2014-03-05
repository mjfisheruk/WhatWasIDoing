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
            if (!Directory.Exists(baseDirectory))
            {
                Directory.CreateDirectory(baseDirectory);
            }

            String dir = entryDirectory(entry);
            String path = dir + "\\" + entry.Time.ToString("yyyy-MM-dd") + ".txt";
            
            TextWriter writer = File.AppendText(path);
            writer.WriteLine(entry.Time.ToString("HH:mm") + " - " + entry.Text);
            writer.Close();
        }

        public void logShutdown()
        {
            SaveEntry("[Shutdown]");
        }

        public void logStart()
        {
            SaveEntry("[Startup]");
        }

        private string entryDirectory(LogEntry entry)
        {
            return baseDirectory;
        }

    }
}
