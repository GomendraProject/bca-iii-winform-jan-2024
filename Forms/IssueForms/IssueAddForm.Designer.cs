using System.ComponentModel;

namespace BCA_III_jan_2024.Forms.IssueForms
{
    partial class IssueAddForm
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
            this.addBtn = new System.Windows.Forms.Button();
            this.nameElm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.assignedToUserList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(103, 186);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(208, 78);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // nameElm
            // 
            this.nameElm.Location = new System.Drawing.Point(44, 54);
            this.nameElm.Name = "nameElm";
            this.nameElm.Size = new System.Drawing.Size(315, 22);
            this.nameElm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // assignedToUserList
            // 
            this.assignedToUserList.FormattingEnabled = true;
            this.assignedToUserList.Location = new System.Drawing.Point(44, 127);
            this.assignedToUserList.Name = "assignedToUserList";
            this.assignedToUserList.Size = new System.Drawing.Size(309, 24);
            this.assignedToUserList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(44, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assigned To";
            // 
            // IssueAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 305);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.assignedToUserList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameElm);
            this.Controls.Add(this.addBtn);
            this.Name = "IssueAddForm";
            this.Text = "IssueAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox assignedToUserList;

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox nameElm;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}