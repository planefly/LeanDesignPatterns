namespace MediatorPattern
{
    partial class LoginFrame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOK = new MediatorPattern.ColleagueButton();
            this.buttonCancel = new MediatorPattern.ColleagueButton();
            this.textPass = new MediatorPattern.ColleagueTextField();
            this.textUser = new MediatorPattern.ColleagueTextField();
            this.checkLogin = new MediatorPattern.ColleagueCheckbox();
            this.checkGuest = new MediatorPattern.ColleagueCheckbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(201, 181);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(282, 181);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(137, 105);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(135, 21);
            this.textPass.TabIndex = 9;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(137, 65);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(135, 21);
            this.textUser.TabIndex = 8;
            // 
            // checkLogin
            // 
            this.checkLogin.AutoSize = true;
            this.checkLogin.Location = new System.Drawing.Point(219, 29);
            this.checkLogin.Name = "checkLogin";
            this.checkLogin.Size = new System.Drawing.Size(53, 16);
            this.checkLogin.TabIndex = 1;
            this.checkLogin.TabStop = true;
            this.checkLogin.Text = "Login";
            this.checkLogin.UseVisualStyleBackColor = true;
            // 
            // checkGuest
            // 
            this.checkGuest.AutoSize = true;
            this.checkGuest.Location = new System.Drawing.Point(137, 29);
            this.checkGuest.Name = "checkGuest";
            this.checkGuest.Size = new System.Drawing.Size(53, 16);
            this.checkGuest.TabIndex = 0;
            this.checkGuest.TabStop = true;
            this.checkGuest.Text = "Guest";
            this.checkGuest.UseVisualStyleBackColor = true;
            // 
            // LoginFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 216);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkLogin);
            this.Controls.Add(this.checkGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator Sample";
            this.Load += new System.EventHandler(this.LoginFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColleagueCheckbox checkGuest;
        private ColleagueCheckbox checkLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ColleagueTextField textUser;
        private ColleagueTextField textPass;
        private ColleagueButton buttonCancel;
        private ColleagueButton buttonOK;
    }
}