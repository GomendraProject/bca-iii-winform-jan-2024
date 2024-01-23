namespace BCA_III_jan_2024.Forms
{
    partial class Dashboard
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
            this.userListElm = new System.Windows.Forms.DataGridView();
            this.noticeFormElm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userListElm)).BeginInit();
            this.SuspendLayout();
            // 
            // userListElm
            // 
            this.userListElm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userListElm.Location = new System.Drawing.Point(10, 73);
            this.userListElm.Name = "userListElm";
            this.userListElm.RowTemplate.Height = 24;
            this.userListElm.Size = new System.Drawing.Size(781, 309);
            this.userListElm.TabIndex = 0;
            // 
            // noticeFormElm
            // 
            this.noticeFormElm.Location = new System.Drawing.Point(613, 7);
            this.noticeFormElm.Name = "noticeFormElm";
            this.noticeFormElm.Size = new System.Drawing.Size(177, 57);
            this.noticeFormElm.TabIndex = 1;
            this.noticeFormElm.Text = "Notice Manager";
            this.noticeFormElm.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.noticeFormElm);
            this.Controls.Add(this.userListElm);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.userListElm)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button noticeFormElm;

        private System.Windows.Forms.DataGridView userListElm;

        #endregion
    }
}