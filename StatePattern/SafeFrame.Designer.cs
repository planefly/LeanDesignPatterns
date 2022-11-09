namespace StatePattern
{
    partial class SafeFrame
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
            this.textClock = new System.Windows.Forms.TextBox();
            this.textScreen = new System.Windows.Forms.TextBox();
            this.buttonUse = new System.Windows.Forms.Button();
            this.buttonAlarm = new System.Windows.Forms.Button();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textClock
            // 
            this.textClock.Location = new System.Drawing.Point(12, 12);
            this.textClock.Name = "textClock";
            this.textClock.ReadOnly = true;
            this.textClock.Size = new System.Drawing.Size(570, 21);
            this.textClock.TabIndex = 0;
            // 
            // textScreen
            // 
            this.textScreen.Location = new System.Drawing.Point(12, 39);
            this.textScreen.Multiline = true;
            this.textScreen.Name = "textScreen";
            this.textScreen.ReadOnly = true;
            this.textScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textScreen.Size = new System.Drawing.Size(570, 254);
            this.textScreen.TabIndex = 1;
            // 
            // buttonUse
            // 
            this.buttonUse.Location = new System.Drawing.Point(138, 299);
            this.buttonUse.Name = "buttonUse";
            this.buttonUse.Size = new System.Drawing.Size(75, 23);
            this.buttonUse.TabIndex = 2;
            this.buttonUse.Text = "使用金库";
            this.buttonUse.UseVisualStyleBackColor = true;
            this.buttonUse.Click += new System.EventHandler(this.ButtonUse_Click);
            // 
            // buttonAlarm
            // 
            this.buttonAlarm.Location = new System.Drawing.Point(219, 299);
            this.buttonAlarm.Name = "buttonAlarm";
            this.buttonAlarm.Size = new System.Drawing.Size(75, 23);
            this.buttonAlarm.TabIndex = 3;
            this.buttonAlarm.Text = "按下警铃";
            this.buttonAlarm.UseVisualStyleBackColor = true;
            this.buttonAlarm.Click += new System.EventHandler(this.ButtonAlarm_Click);
            // 
            // buttonPhone
            // 
            this.buttonPhone.Location = new System.Drawing.Point(300, 299);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(75, 23);
            this.buttonPhone.TabIndex = 4;
            this.buttonPhone.Text = "正常通话";
            this.buttonPhone.UseVisualStyleBackColor = true;
            this.buttonPhone.Click += new System.EventHandler(this.ButtonPhone_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(381, 299);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "结束";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // SafeFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 334);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPhone);
            this.Controls.Add(this.buttonAlarm);
            this.Controls.Add(this.buttonUse);
            this.Controls.Add(this.textScreen);
            this.Controls.Add(this.textClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SafeFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SafeFrame_FormClosing);
            this.Load += new System.EventHandler(this.SafeFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textClock;
        private System.Windows.Forms.TextBox textScreen;
        private System.Windows.Forms.Button buttonUse;
        private System.Windows.Forms.Button buttonAlarm;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonExit;
    }
}