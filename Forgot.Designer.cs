
namespace Ecolog
{
    partial class Forgot
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
            this.fgtTltLbl = new System.Windows.Forms.Label();
            this.fgtGrpBox = new System.Windows.Forms.GroupBox();
            this.expLbl = new System.Windows.Forms.Label();
            this.sendCodeBtn = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.pwGrpBox = new System.Windows.Forms.GroupBox();
            this.rstpwLbl = new System.Windows.Forms.Button();
            this.confirmTB = new System.Windows.Forms.TextBox();
            this.confPWLbl = new System.Windows.Forms.Label();
            this.newPwTB = new System.Windows.Forms.TextBox();
            this.newPwLbl = new System.Windows.Forms.Label();
            this.codeLbl = new System.Windows.Forms.Label();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.codeBtn = new System.Windows.Forms.Button();
            this.codeGrpBox = new System.Windows.Forms.GroupBox();
            this.codeExpLbl = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.fgtGrpBox.SuspendLayout();
            this.pwGrpBox.SuspendLayout();
            this.codeGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fgtTltLbl
            // 
            this.fgtTltLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fgtTltLbl.AutoSize = true;
            this.fgtTltLbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgtTltLbl.ForeColor = System.Drawing.Color.Green;
            this.fgtTltLbl.Location = new System.Drawing.Point(114, 9);
            this.fgtTltLbl.MinimumSize = new System.Drawing.Size(117, 25);
            this.fgtTltLbl.Name = "fgtTltLbl";
            this.fgtTltLbl.Size = new System.Drawing.Size(256, 32);
            this.fgtTltLbl.TabIndex = 0;
            this.fgtTltLbl.Text = "Forgot Password?";
            // 
            // fgtGrpBox
            // 
            this.fgtGrpBox.Controls.Add(this.expLbl);
            this.fgtGrpBox.Controls.Add(this.sendCodeBtn);
            this.fgtGrpBox.Controls.Add(this.emailTB);
            this.fgtGrpBox.Controls.Add(this.emailLbl);
            this.fgtGrpBox.Location = new System.Drawing.Point(15, 68);
            this.fgtGrpBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fgtGrpBox.Name = "fgtGrpBox";
            this.fgtGrpBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fgtGrpBox.Size = new System.Drawing.Size(454, 96);
            this.fgtGrpBox.TabIndex = 1;
            this.fgtGrpBox.TabStop = false;
            // 
            // expLbl
            // 
            this.expLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.expLbl.AutoSize = true;
            this.expLbl.BackColor = System.Drawing.Color.Transparent;
            this.expLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.expLbl.Location = new System.Drawing.Point(6, 11);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(220, 32);
            this.expLbl.TabIndex = 4;
            this.expLbl.Text = "Enter your Email you receive a code.\r\n\r\n";
            // 
            // sendCodeBtn
            // 
            this.sendCodeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.sendCodeBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.sendCodeBtn.Location = new System.Drawing.Point(322, 56);
            this.sendCodeBtn.Name = "sendCodeBtn";
            this.sendCodeBtn.Size = new System.Drawing.Size(115, 23);
            this.sendCodeBtn.TabIndex = 2;
            this.sendCodeBtn.Text = "Send Code";
            this.sendCodeBtn.UseVisualStyleBackColor = false;
            this.sendCodeBtn.Click += new System.EventHandler(this.sendCodeBtn_Click);
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(177, 56);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 22);
            this.emailTB.TabIndex = 1;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.emailLbl.Location = new System.Drawing.Point(119, 59);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(40, 16);
            this.emailLbl.TabIndex = 0;
            this.emailLbl.Text = "Email";
            // 
            // pwGrpBox
            // 
            this.pwGrpBox.Controls.Add(this.rstpwLbl);
            this.pwGrpBox.Controls.Add(this.confirmTB);
            this.pwGrpBox.Controls.Add(this.confPWLbl);
            this.pwGrpBox.Controls.Add(this.newPwTB);
            this.pwGrpBox.Controls.Add(this.newPwLbl);
            this.pwGrpBox.Location = new System.Drawing.Point(15, 314);
            this.pwGrpBox.Name = "pwGrpBox";
            this.pwGrpBox.Size = new System.Drawing.Size(454, 96);
            this.pwGrpBox.TabIndex = 3;
            this.pwGrpBox.TabStop = false;
            // 
            // rstpwLbl
            // 
            this.rstpwLbl.BackColor = System.Drawing.SystemColors.Control;
            this.rstpwLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.rstpwLbl.Location = new System.Drawing.Point(322, 53);
            this.rstpwLbl.Name = "rstpwLbl";
            this.rstpwLbl.Size = new System.Drawing.Size(115, 23);
            this.rstpwLbl.TabIndex = 6;
            this.rstpwLbl.Text = "Reset Password";
            this.rstpwLbl.UseVisualStyleBackColor = false;
            // 
            // confirmTB
            // 
            this.confirmTB.Location = new System.Drawing.Point(177, 54);
            this.confirmTB.MinimumSize = new System.Drawing.Size(100, 20);
            this.confirmTB.Name = "confirmTB";
            this.confirmTB.Size = new System.Drawing.Size(100, 22);
            this.confirmTB.TabIndex = 5;
            // 
            // confPWLbl
            // 
            this.confPWLbl.AutoSize = true;
            this.confPWLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confPWLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.confPWLbl.Location = new System.Drawing.Point(58, 57);
            this.confPWLbl.Name = "confPWLbl";
            this.confPWLbl.Size = new System.Drawing.Size(112, 16);
            this.confPWLbl.TabIndex = 4;
            this.confPWLbl.Text = "Confirm Password";
            // 
            // newPwTB
            // 
            this.newPwTB.Location = new System.Drawing.Point(177, 21);
            this.newPwTB.MinimumSize = new System.Drawing.Size(100, 20);
            this.newPwTB.Name = "newPwTB";
            this.newPwTB.Size = new System.Drawing.Size(100, 22);
            this.newPwTB.TabIndex = 3;
            // 
            // newPwLbl
            // 
            this.newPwLbl.AutoSize = true;
            this.newPwLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPwLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.newPwLbl.Location = new System.Drawing.Point(77, 24);
            this.newPwLbl.Name = "newPwLbl";
            this.newPwLbl.Size = new System.Drawing.Size(93, 16);
            this.newPwLbl.TabIndex = 2;
            this.newPwLbl.Text = "New Password";
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.codeLbl.Location = new System.Drawing.Point(85, 53);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(85, 16);
            this.codeLbl.TabIndex = 0;
            this.codeLbl.Text = "Backup Code";
            // 
            // codeTB
            // 
            this.codeTB.Location = new System.Drawing.Point(177, 50);
            this.codeTB.MinimumSize = new System.Drawing.Size(100, 20);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(100, 22);
            this.codeTB.TabIndex = 1;
            // 
            // codeBtn
            // 
            this.codeBtn.BackColor = System.Drawing.SystemColors.Control;
            this.codeBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.codeBtn.Location = new System.Drawing.Point(322, 50);
            this.codeBtn.Name = "codeBtn";
            this.codeBtn.Size = new System.Drawing.Size(115, 23);
            this.codeBtn.TabIndex = 2;
            this.codeBtn.Text = "Confirm Code";
            this.codeBtn.UseVisualStyleBackColor = false;
            this.codeBtn.Click += new System.EventHandler(this.codeBtn_Click);
            // 
            // codeGrpBox
            // 
            this.codeGrpBox.Controls.Add(this.codeExpLbl);
            this.codeGrpBox.Controls.Add(this.codeBtn);
            this.codeGrpBox.Controls.Add(this.codeTB);
            this.codeGrpBox.Controls.Add(this.codeLbl);
            this.codeGrpBox.Location = new System.Drawing.Point(15, 191);
            this.codeGrpBox.Name = "codeGrpBox";
            this.codeGrpBox.Size = new System.Drawing.Size(454, 96);
            this.codeGrpBox.TabIndex = 2;
            this.codeGrpBox.TabStop = false;
            // 
            // codeExpLbl
            // 
            this.codeExpLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.codeExpLbl.BackColor = System.Drawing.Color.Transparent;
            this.codeExpLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeExpLbl.ForeColor = System.Drawing.Color.ForestGreen;
            this.codeExpLbl.Location = new System.Drawing.Point(6, 4);
            this.codeExpLbl.Name = "codeExpLbl";
            this.codeExpLbl.Size = new System.Drawing.Size(262, 43);
            this.codeExpLbl.TabIndex = 5;
            this.codeExpLbl.Text = "\r\nEnter the code sent to reset your password.\r\n";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.SystemColors.Control;
            this.backBtn.ForeColor = System.Drawing.Color.ForestGreen;
            this.backBtn.Location = new System.Drawing.Point(191, 426);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(102, 23);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.ForeColor = System.Drawing.Color.Red;
            this.msgLbl.Location = new System.Drawing.Point(203, 45);
            this.msgLbl.MinimumSize = new System.Drawing.Size(100, 20);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(100, 20);
            this.msgLbl.TabIndex = 5;
            // 
            // Forgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.pwGrpBox);
            this.Controls.Add(this.codeGrpBox);
            this.Controls.Add(this.fgtTltLbl);
            this.Controls.Add(this.fgtGrpBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Forgot";
            this.Text = "Forgot";
            this.fgtGrpBox.ResumeLayout(false);
            this.fgtGrpBox.PerformLayout();
            this.pwGrpBox.ResumeLayout(false);
            this.pwGrpBox.PerformLayout();
            this.codeGrpBox.ResumeLayout(false);
            this.codeGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fgtTltLbl;
        private System.Windows.Forms.GroupBox fgtGrpBox;
        private System.Windows.Forms.Label expLbl;
        private System.Windows.Forms.Button sendCodeBtn;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.GroupBox pwGrpBox;
        private System.Windows.Forms.Button rstpwLbl;
        private System.Windows.Forms.TextBox confirmTB;
        private System.Windows.Forms.Label confPWLbl;
        private System.Windows.Forms.TextBox newPwTB;
        private System.Windows.Forms.Label newPwLbl;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.Button codeBtn;
        private System.Windows.Forms.GroupBox codeGrpBox;
        private System.Windows.Forms.Label codeExpLbl;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label msgLbl;
    }
}