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
        private bool firstTimeRunning;
        private bool closeRequestedFromMenu;
        private TimeLog timeLog;

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
                LastEntryLabel.Text = timeLog.LastEntry.Text;
            }
            
            base.SetVisibleCore(value);
        }

        private void hideAndResetTimer()
        {
            Hide();
            ReminderTimer.Stop();
            ReminderTimer.Start();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            Show();
            ActivityTextBox.Text = "";
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
            timeLog.SaveEntry(ActivityTextBox.Text);
            ActivityTextBox.Text = "";
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

        private void activityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                ActivityTextBox.Text = timeLog.LastEntry.Text;
                ActivityTextBox.SelectionStart = ActivityTextBox.Text.Length;
            }
            else if (e.KeyCode == Keys.Up)
            {
                ActivityTextBox.Text = "";
            }
        }
    }
}

