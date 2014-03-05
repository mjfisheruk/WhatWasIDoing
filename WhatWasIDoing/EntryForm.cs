using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WhatWasIDoing
{
    public partial class EntryForm : Form
    {
        bool firstTimeRunning;
        bool closeRequestedFromMenu;
        TimeLog timeLog;

        public EntryForm()
        {
            firstTimeRunning = true;
            closeRequestedFromMenu = false;
            InitializeComponent();
            String homeDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            String saveDirectory = homeDirectory + "\\WhatWasIDoing";
            timeLog = new TimeLog(saveDirectory);
            timeLog.LogStartup();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (firstTimeRunning)
            {
                value = false;
                firstTimeRunning = false;
            }
            
            if(timeLog.HasLastEntry)
            {
                lastEntryLabel.Text = timeLog.LastEntry.Text;
            }
            
            base.SetVisibleCore(value);
        }

        private void hideAndResetTimer()
        {
            Hide();
            reminderTimer.Stop();
            reminderTimer.Start();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void EntryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!closeRequestedFromMenu)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                timeLog.LogShutdown();
            }
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            timeLog.SaveEntry(activityTextBox.Text);
            activityTextBox.Text = "";
            hideAndResetTimer();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hideAndResetTimer();
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            closeRequestedFromMenu = true;
            Close();
        }
    }
}

