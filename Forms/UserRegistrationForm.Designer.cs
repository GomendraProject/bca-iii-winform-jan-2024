using System.ComponentModel;

namespace BCA_III_jan_2024.Forms
{
    partial class UserRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.usernameElm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordElm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usernameElm
            // 
            this.usernameElm.Location = new System.Drawing.Point(40, 56);
            this.usernameElm.Name = "usernameElm";
            this.usernameElm.Size = new System.Drawing.Size(694, 22);
            this.usernameElm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(40, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // passwordElm
            // 
            this.passwordElm.Location = new System.Drawing.Point(40, 137);
            this.passwordElm.Name = "passwordElm";
            this.passwordElm.PasswordChar = '*';
            this.passwordElm.Size = new System.Drawing.Size(694, 22);
            this.passwordElm.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(53, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm Password";
            // 
            // confirmPassword
            // 
            this.confirmPassword.Location = new System.Drawing.Point(53, 233);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.PasswordChar = '*';
            this.confirmPassword.Size = new System.Drawing.Size(681, 22);
            this.confirmPassword.TabIndex = 4;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(252, 298);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(281, 90);
            this.registerButton.TabIndex = 6;
            this.registerButton.Text = "Register!";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // UserRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordElm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameElm);
            this.Name = "UserRegistrationForm";
            this.Text = "UserRegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox usernameElm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordElm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmPassword;
        private System.Windows.Forms.Button registerButton;

        #endregion
    }
}