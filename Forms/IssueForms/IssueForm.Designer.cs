using System.ComponentModel;

namespace BCA_III_jan_2024.Forms.IssueForms
{
    partial class IssueForm
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
            this.issueListElm = new System.Windows.Forms.DataGridView();
            this.nameElm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtnElm = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.assignedUserElm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issueListElm)).BeginInit();
            this.SuspendLayout();
            // 
            // issueListElm
            // 
            this.issueListElm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.issueListElm.Location = new System.Drawing.Point(0, 86);
            this.issueListElm.Name = "issueListElm";
            this.issueListElm.RowTemplate.Height = 24;
            this.issueListElm.Size = new System.Drawing.Size(797, 353);
            this.issueListElm.TabIndex = 0;
            // 
            // nameElm
            // 
            this.nameElm.Location = new System.Drawing.Point(12, 36);
            this.nameElm.Name = "nameElm";
            this.nameElm.Size = new System.Drawing.Size(224, 22);
            this.nameElm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // addBtnElm
            // 
            this.addBtnElm.Location = new System.Drawing.Point(676, 22);
            this.addBtnElm.Name = "addBtnElm";
            this.addBtnElm.Size = new System.Drawing.Size(101, 48);
            this.addBtnElm.TabIndex = 3;
            this.addBtnElm.Text = "Add";
            this.addBtnElm.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(555, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(101, 48);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // assignedUserElm
            // 
            this.assignedUserElm.FormattingEnabled = true;
            this.assignedUserElm.Location = new System.Drawing.Point(256, 34);
            this.assignedUserElm.Name = "assignedUserElm";
            this.assignedUserElm.Size = new System.Drawing.Size(217, 24);
            this.assignedUserElm.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assigned User";
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignedUserElm);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.addBtnElm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameElm);
            this.Controls.Add(this.issueListElm);
            this.Name = "IssueForm";
            this.Text = "IssueForm";
            ((System.ComponentModel.ISupportInitialize)(this.issueListElm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox assignedUserElm;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button searchBtn;

        private System.Windows.Forms.Button addBtnElm;

        private System.Windows.Forms.TextBox nameElm;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView issueListElm;

        #endregion
    }
}