namespace BCA_III_jan_2024
{
    partial class Form1
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameElm = new System.Windows.Forms.TextBox();
            this.passwordElm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginElm = new System.Windows.Forms.Button();
            this.registerElm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(34, 23);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(73, 17);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // usernameElm
            // 
            this.usernameElm.Location = new System.Drawing.Point(37, 53);
            this.usernameElm.Name = "usernameElm";
            this.usernameElm.Size = new System.Drawing.Size(367, 22);
            this.usernameElm.TabIndex = 1;
            // 
            // passwordElm
            // 
            this.passwordElm.Location = new System.Drawing.Point(37, 127);
            this.passwordElm.Name = "passwordElm";
            this.passwordElm.PasswordChar = '*';
            this.passwordElm.Size = new System.Drawing.Size(367, 22);
            this.passwordElm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // loginElm
            // 
            this.loginElm.Location = new System.Drawing.Point(117, 181);
            this.loginElm.Name = "loginElm";
            this.loginElm.Size = new System.Drawing.Size(217, 23);
            this.loginElm.TabIndex = 4;
            this.loginElm.Text = "Login!";
            this.loginElm.UseVisualStyleBackColor = true;
            // 
            // registerElm
            // 
            this.registerElm.Location = new System.Drawing.Point(124, 250);
            this.registerElm.Name = "registerElm";
            this.registerElm.Size = new System.Drawing.Size(209, 30);
            this.registerElm.TabIndex = 5;
            this.registerElm.Text = "Register Now!";
            this.registerElm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 528);
            this.Controls.Add(this.registerElm);
            this.Controls.Add(this.loginElm);
            this.Controls.Add(this.passwordElm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameElm);
            this.Controls.Add(this.usernameLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button registerElm;

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox usernameElm;
        private System.Windows.Forms.TextBox passwordElm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginElm;
    }
}

