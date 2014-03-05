using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatWasIDoing
{
    class TimeLog
    {
        String saveDirectory;

        public TimeLog(String saveDirectory)
        {
            this.saveDirectory = saveDirectory;
        }

        public void SaveActivity(String text)
        {
            SaveActivity(new LogEntry(text));
        }

        public void logStart()
        {
            SaveActivity("[Startup]");
        }

        private void SaveActivity(LogEntry activity)
        {
            if (!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            String fileName = saveDirectory + "\\" + activity.Time.ToString("yyyy-MM-dd") + ".txt";
            String timeStamp = DateTime.Now.ToString("HH:mm");
            TextWriter writer = File.AppendText(fileName);
            writer.WriteLine(timeStamp + " - " + activity.Text);
            writer.Close();
        }

        internal void logShutdown()
        {
            SaveActivity("[Shutdown]");
        }
    }
}
