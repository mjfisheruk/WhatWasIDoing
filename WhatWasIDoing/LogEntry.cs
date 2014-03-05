using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatWasIDoing
{
    class LogEntry
    {
        private string text;
        private DateTime time;

        public string Text { get { return text; } }
        public DateTime Time { get { return time; } }

        public LogEntry(string text) : this(text, DateTime.Now) {}

        public LogEntry(string text, DateTime time)
        {
            this.text = text;
            this.time = DateTime.Now;
        }

        public override string ToString()
        {
            return time.ToString("HH:mm") + " - " + text;
        }

        public static LogEntry FromString(string line, DateTime dateTime)
        {
            var hours = line.Substring(0, 2);
            var mins = line.Substring(3,2);
            var text = line.Substring(8);

            var timeStamp = dateTime.Date;
            timeStamp.AddHours(Double.Parse(hours));
            timeStamp.AddMinutes(Double.Parse(mins));

            return new LogEntry(text, timeStamp);
        }
    }
}
