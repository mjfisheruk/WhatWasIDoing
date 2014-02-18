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
            this.label1 = new System.Windows.Forms.Label();
            this.activityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.quitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reminderTimer = new System.Windows.Forms.Timer(this.components);
            this.iconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What have you been doing during the last 30 mins?";
            // 
            // activityTextBox
            // 
            this.activityTextBox.Location = new System.Drawing.Point(19, 33);
            this.activityTextBox.Name = "activityTextBox";
            this.activityTextBox.Size = new System.Drawing.Size(753, 20);
            this.activityTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(616, 59);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "&Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(697, 59);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "What was I doing?";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // iconContextMenu
            // 
            this.iconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitMenuItem});
            this.iconContextMenu.Name = "iconContextMenu";
            this.iconContextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Name = "quitMenuItem";
            this.quitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitMenuItem.Text = "&Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.quitMenuItem_Click);
            // 
            // reminderTimer
            // 
            this.reminderTimer.Enabled = true;
            this.reminderTimer.Interval = 1800000;
            this.reminderTimer.Tick += new System.EventHandler(this.reminderTimer_Tick);
            // 
            // EntryForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 92);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.activityTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "What the hell were you doing?";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryForm_FormClosing);
            this.iconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox activityTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer reminderTimer;
        private System.Windows.Forms.ContextMenuStrip iconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem quitMenuItem;
    }
}

