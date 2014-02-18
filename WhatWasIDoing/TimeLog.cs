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
            if(!Directory.Exists(saveDirectory))
            {
                Directory.CreateDirectory(saveDirectory);
            }

            String fileName = saveDirectory + "\\" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            String timeStamp = DateTime.Now.ToString("HH:mm");
            TextWriter writer = File.AppendText(fileName);
            writer.WriteLine(timeStamp + " - " + text);
            writer.Close();
        }
    }
}
