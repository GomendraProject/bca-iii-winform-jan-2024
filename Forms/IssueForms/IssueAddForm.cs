using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using BCA_III_jan_2024.Models;
using BCA_III_jan_2024.Providers;
using BCA_III_jan_2024.Repository;
using Dapper;

namespace BCA_III_jan_2024.Forms.IssueForms
{
    public partial class IssueAddForm : Form
    {

        public BindingList<AppUser> userBindingList = new BindingList<AppUser>();
        public IssueAddForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.AttachEventHandlers();
            var users = UserRepository.GetUsers();
            
            userBindingList.Clear();
            
            foreach (var user in users)
            {
                userBindingList.Add(user);
            }

            assignedToUserList.DataSource = userBindingList;
            assignedToUserList.DisplayMember = nameof(AppUser.Username);            
            assignedToUserList.ValueMember = nameof(AppUser.Id);
        }

        private void AttachEventHandlers()
        {
            addBtn.Click += AddBtnOnClick;
        }

        private void AddBtnOnClick(object sender, EventArgs e)
        {
            try
            {
                using (var conn = ConnectionProvider.GetConnection())
                {
                    var insertQuery = @"
INSERT INTO `issue`
(
    `Name`,
    `Description`,
    `CreatedByUserId`,
    `AssignedToUserId`
)
VALUES
(
    @name,
    @description,
    @createdByUserId,
    @assignedToUserId
);
";
                    var name = nameElm.Text;
                    var selectedUser = assignedToUserList.SelectedItem as AppUser;
                    if (string.IsNullOrEmpty(name))
                    {
                        throw new Exception("Please input name");
                    }
                    if (selectedUser == null)
                    {
                        throw new Exception("User not selected");
                    }

                    var userId = selectedUser.Id;
                    conn.Execute(insertQuery, new
                    {
                        name = name,
                        description = "Task issue recorded",
                        createdByUserId = userId,
                        assignedToUserId = userId
                    });
                    MessageBox.Show("Issue created");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}