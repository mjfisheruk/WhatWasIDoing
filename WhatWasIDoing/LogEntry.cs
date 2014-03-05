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
    }
}
