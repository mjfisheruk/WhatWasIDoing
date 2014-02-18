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
        bool setVisibleCoreStartup;
        bool closeRequestFromMenu;
        TimeLog timeLog;

        public EntryForm()
        {
            setVisibleCoreStartup = true;
            closeRequestFromMenu = false;
            InitializeComponent();
            String homeDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            String saveDirectory = homeDirectory + "\\WhatWasIDoing";
            timeLog = new TimeLog(saveDirectory);
        }

        protected override void SetVisibleCore(bool value)
        {
            if (setVisibleCoreStartup)
            {
                value = false;
                setVisibleCoreStartup = false;
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
            if (!closeRequestFromMenu)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            timeLog.SaveActivity(activityTextBox.Text);
            activityTextBox.Text = "";
            hideAndResetTimer();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            hideAndResetTimer();
        }

        private void quitMenuItem_Click(object sender, EventArgs e)
        {
            closeRequestFromMenu = true;
            Close();
        }
    }
}

