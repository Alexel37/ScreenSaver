
namespace Alexel37ScreenSaver
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MultiMonitorLabel = new System.Windows.Forms.LinkLabel();
            this.AddButton = new System.Windows.Forms.Button();
            this.ScreensComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ScreenInformationTextBox = new System.Windows.Forms.RichTextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.SaveConfigurationButton = new System.Windows.Forms.Button();
            this.DisablePrefix = new System.Windows.Forms.Label();
            this.DisableTextBox = new System.Windows.Forms.TextBox();
            this.ScreenNameTextBox = new System.Windows.Forms.TextBox();
            this.DisablePostfix = new System.Windows.Forms.Label();
            this.DelayPostfix = new System.Windows.Forms.Label();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.DelayPrefix = new System.Windows.Forms.Label();
            this.AddSkipAreaButton = new System.Windows.Forms.Button();
            this.ToogleDebugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MultiMonitorLabel
            // 
            this.MultiMonitorLabel.AutoSize = true;
            this.MultiMonitorLabel.Location = new System.Drawing.Point(13, 13);
            this.MultiMonitorLabel.Name = "MultiMonitorLabel";
            this.MultiMonitorLabel.Size = new System.Drawing.Size(300, 13);
            this.MultiMonitorLabel.TabIndex = 0;
            this.MultiMonitorLabel.TabStop = true;
            this.MultiMonitorLabel.Text = "For utility to work MultiMonitorTool need to be near executable";
            this.MultiMonitorLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MultiMonitorLabel_LinkClicked);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(238, 29);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ScreensComboBox
            // 
            this.ScreensComboBox.FormattingEnabled = true;
            this.ScreensComboBox.Location = new System.Drawing.Point(12, 147);
            this.ScreensComboBox.Name = "ScreensComboBox";
            this.ScreensComboBox.Size = new System.Drawing.Size(220, 21);
            this.ScreensComboBox.TabIndex = 2;
            this.ScreensComboBox.SelectedIndexChanged += new System.EventHandler(this.ScreensComboBox_SelectedIndexChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(239, 144);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ScreenInformationTextBox
            // 
            this.ScreenInformationTextBox.Enabled = false;
            this.ScreenInformationTextBox.Location = new System.Drawing.Point(13, 175);
            this.ScreenInformationTextBox.Name = "ScreenInformationTextBox";
            this.ScreenInformationTextBox.Size = new System.Drawing.Size(300, 96);
            this.ScreenInformationTextBox.TabIndex = 5;
            this.ScreenInformationTextBox.Text = "";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(238, 277);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 65);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SaveConfigurationButton
            // 
            this.SaveConfigurationButton.Location = new System.Drawing.Point(157, 277);
            this.SaveConfigurationButton.Name = "SaveConfigurationButton";
            this.SaveConfigurationButton.Size = new System.Drawing.Size(75, 65);
            this.SaveConfigurationButton.TabIndex = 7;
            this.SaveConfigurationButton.Text = "Save";
            this.SaveConfigurationButton.UseVisualStyleBackColor = true;
            this.SaveConfigurationButton.Click += new System.EventHandler(this.SaveConfigurationButton_Click);
            // 
            // DisablePrefix
            // 
            this.DisablePrefix.AutoSize = true;
            this.DisablePrefix.Location = new System.Drawing.Point(13, 67);
            this.DisablePrefix.Name = "DisablePrefix";
            this.DisablePrefix.Size = new System.Drawing.Size(101, 13);
            this.DisablePrefix.TabIndex = 9;
            this.DisablePrefix.Text = "Disable screen after";
            // 
            // DisableTextBox
            // 
            this.DisableTextBox.Location = new System.Drawing.Point(145, 65);
            this.DisableTextBox.Name = "DisableTextBox";
            this.DisableTextBox.Size = new System.Drawing.Size(87, 20);
            this.DisableTextBox.TabIndex = 10;
            this.DisableTextBox.Text = "5";
            this.DisableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ScreenNameTextBox
            // 
            this.ScreenNameTextBox.Location = new System.Drawing.Point(17, 32);
            this.ScreenNameTextBox.Name = "ScreenNameTextBox";
            this.ScreenNameTextBox.Size = new System.Drawing.Size(215, 20);
            this.ScreenNameTextBox.TabIndex = 11;
            this.ScreenNameTextBox.Text = "Screen name";
            // 
            // DisablePostfix
            // 
            this.DisablePostfix.AutoSize = true;
            this.DisablePostfix.Location = new System.Drawing.Point(238, 67);
            this.DisablePostfix.Name = "DisablePostfix";
            this.DisablePostfix.Size = new System.Drawing.Size(43, 13);
            this.DisablePostfix.TabIndex = 12;
            this.DisablePostfix.Text = "minutes";
            // 
            // DelayPostfix
            // 
            this.DelayPostfix.AutoSize = true;
            this.DelayPostfix.Location = new System.Drawing.Point(238, 93);
            this.DelayPostfix.Name = "DelayPostfix";
            this.DelayPostfix.Size = new System.Drawing.Size(47, 13);
            this.DelayPostfix.TabIndex = 15;
            this.DelayPostfix.Text = "seconds";
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(145, 91);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(87, 20);
            this.DelayTextBox.TabIndex = 14;
            this.DelayTextBox.Text = "10";
            this.DelayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DelayPrefix
            // 
            this.DelayPrefix.AutoSize = true;
            this.DelayPrefix.Location = new System.Drawing.Point(13, 93);
            this.DelayPrefix.Name = "DelayPrefix";
            this.DelayPrefix.Size = new System.Drawing.Size(126, 13);
            this.DelayPrefix.TabIndex = 13;
            this.DelayPrefix.Text = "Check for changes every";
            // 
            // AddSkipAreaButton
            // 
            this.AddSkipAreaButton.Location = new System.Drawing.Point(145, 115);
            this.AddSkipAreaButton.Name = "AddSkipAreaButton";
            this.AddSkipAreaButton.Size = new System.Drawing.Size(168, 23);
            this.AddSkipAreaButton.TabIndex = 16;
            this.AddSkipAreaButton.Text = "Add skip area";
            this.AddSkipAreaButton.UseVisualStyleBackColor = true;
            this.AddSkipAreaButton.Click += new System.EventHandler(this.AddSkipAreaButton_Click);
            // 
            // ToogleDebugButton
            // 
            this.ToogleDebugButton.Location = new System.Drawing.Point(12, 278);
            this.ToogleDebugButton.Name = "ToogleDebugButton";
            this.ToogleDebugButton.Size = new System.Drawing.Size(75, 64);
            this.ToogleDebugButton.TabIndex = 17;
            this.ToogleDebugButton.Text = "Save change reason";
            this.ToogleDebugButton.UseVisualStyleBackColor = true;
            this.ToogleDebugButton.Click += new System.EventHandler(this.ToogleDebugButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 356);
            this.Controls.Add(this.ToogleDebugButton);
            this.Controls.Add(this.AddSkipAreaButton);
            this.Controls.Add(this.DelayPostfix);
            this.Controls.Add(this.DelayTextBox);
            this.Controls.Add(this.DelayPrefix);
            this.Controls.Add(this.DisablePostfix);
            this.Controls.Add(this.ScreenNameTextBox);
            this.Controls.Add(this.DisableTextBox);
            this.Controls.Add(this.DisablePrefix);
            this.Controls.Add(this.SaveConfigurationButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ScreenInformationTextBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ScreensComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MultiMonitorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(345, 395);
            this.MinimumSize = new System.Drawing.Size(345, 395);
            this.Name = "MainForm";
            this.Text = "Alexel37ScreenSaver";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel MultiMonitorLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox ScreensComboBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox ScreenInformationTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button SaveConfigurationButton;
        private System.Windows.Forms.Label DisablePrefix;
        private System.Windows.Forms.TextBox DisableTextBox;
        private System.Windows.Forms.TextBox ScreenNameTextBox;
        private System.Windows.Forms.Label DisablePostfix;
        private System.Windows.Forms.Label DelayPostfix;
        private System.Windows.Forms.TextBox DelayTextBox;
        private System.Windows.Forms.Label DelayPrefix;
        private System.Windows.Forms.Button AddSkipAreaButton;
        private System.Windows.Forms.Button ToogleDebugButton;
    }
}

