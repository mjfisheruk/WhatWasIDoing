namespace WhatWasIDoing
{
    partial class EntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.PromptLabel = new System.Windows.Forms.Label();
            this.ActivityTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReminderTimer = new System.Windows.Forms.Timer(this.components);
            this.LastEntryPrompt = new System.Windows.Forms.Label();
            this.LastEntryLabel = new System.Windows.Forms.Label();
            this.IconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Location = new System.Drawing.Point(16, 17);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(250, 13);
            this.PromptLabel.TabIndex = 0;
            this.PromptLabel.Text = "What have you been doing during the last 30 mins?";
            // 
            // ActivityTextBox
            // 
            this.ActivityTextBox.Location = new System.Drawing.Point(19, 33);
            this.ActivityTextBox.Name = "ActivityTextBox";
            this.ActivityTextBox.Size = new System.Drawing.Size(753, 20);
            this.ActivityTextBox.TabIndex = 1;
            this.ActivityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activityTextBox_KeyDown);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(616, 59);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "&Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(697, 59);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.ContextMenuStrip = this.IconContextMenu;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "What was I doing?";
            this.NotifyIcon.Visible = true;
            this.NotifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // IconContextMenu
            // 
            this.IconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitMenuItem});
            this.IconContextMenu.Name = "iconContextMenu";
            this.IconContextMenu.Size = new System.Drawing.Size(98, 26);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitMenuItem.Text = "&Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // ReminderTimer
            // 
            this.ReminderTimer.Enabled = true;
            this.ReminderTimer.Interval = 1800000;
            this.ReminderTimer.Tick += new System.EventHandler(this.reminderTimer_Tick);
            // 
            // LastEntryPrompt
            // 
            this.LastEntryPrompt.AutoSize = true;
            this.LastEntryPrompt.Location = new System.Drawing.Point(16, 64);
            this.LastEntryPrompt.Name = "LastEntryPrompt";
            this.LastEntryPrompt.Size = new System.Drawing.Size(163, 13);
            this.LastEntryPrompt.TabIndex = 4;
            this.LastEntryPrompt.Text = "Last entry (down arrow to select):";
            // 
            // LastEntryLabel
            // 
            this.LastEntryLabel.AutoEllipsis = true;
            this.LastEntryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastEntryLabel.Location = new System.Drawing.Point(185, 64);
            this.LastEntryLabel.Name = "LastEntryLabel";
            this.LastEntryLabel.Size = new System.Drawing.Size(425, 13);
            this.LastEntryLabel.TabIndex = 5;
            this.LastEntryLabel.Text = "                             ";
            // 
            // EntryForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 92);
            this.Controls.Add(this.LastEntryLabel);
            this.Controls.Add(this.LastEntryPrompt);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ActivityTextBox);
            this.Controls.Add(this.PromptLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What were you doing?";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.IconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PromptLabel;
        private System.Windows.Forms.TextBox ActivityTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Timer ReminderTimer;
        private System.Windows.Forms.ContextMenuStrip IconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
        private System.Windows.Forms.Label LastEntryPrompt;
        private System.Windows.Forms.Label LastEntryLabel;
    }
}

