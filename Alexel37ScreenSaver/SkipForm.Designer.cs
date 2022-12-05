
namespace Alexel37ScreenSaver
{
    partial class SkipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkipForm));
            this.TopXTextBox = new System.Windows.Forms.TextBox();
            this.TopYTextBox = new System.Windows.Forms.TextBox();
            this.BottomXTextBox = new System.Windows.Forms.TextBox();
            this.BottomYTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopXTextBox
            // 
            this.TopXTextBox.Location = new System.Drawing.Point(12, 12);
            this.TopXTextBox.Name = "TopXTextBox";
            this.TopXTextBox.Size = new System.Drawing.Size(100, 20);
            this.TopXTextBox.TabIndex = 0;
            // 
            // TopYTextBox
            // 
            this.TopYTextBox.Location = new System.Drawing.Point(118, 12);
            this.TopYTextBox.Name = "TopYTextBox";
            this.TopYTextBox.Size = new System.Drawing.Size(100, 20);
            this.TopYTextBox.TabIndex = 1;
            // 
            // BottomXTextBox
            // 
            this.BottomXTextBox.Location = new System.Drawing.Point(12, 38);
            this.BottomXTextBox.Name = "BottomXTextBox";
            this.BottomXTextBox.Size = new System.Drawing.Size(100, 20);
            this.BottomXTextBox.TabIndex = 2;
            // 
            // BottomYTextBox
            // 
            this.BottomYTextBox.Location = new System.Drawing.Point(118, 38);
            this.BottomYTextBox.Name = "BottomYTextBox";
            this.BottomYTextBox.Size = new System.Drawing.Size(100, 20);
            this.BottomYTextBox.TabIndex = 3;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(142, 97);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SkipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 132);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.BottomYTextBox);
            this.Controls.Add(this.BottomXTextBox);
            this.Controls.Add(this.TopYTextBox);
            this.Controls.Add(this.TopXTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(245, 171);
            this.MinimumSize = new System.Drawing.Size(245, 171);
            this.Name = "SkipForm";
            this.Text = "Skip Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TopXTextBox;
        private System.Windows.Forms.TextBox TopYTextBox;
        private System.Windows.Forms.TextBox BottomXTextBox;
        private System.Windows.Forms.TextBox BottomYTextBox;
        private System.Windows.Forms.Button OkButton;
    }
}