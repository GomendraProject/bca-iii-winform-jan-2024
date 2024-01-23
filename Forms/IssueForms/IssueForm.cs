using System;
using System.ComponentModel;
using System.Windows.Forms;
using BCA_III_jan_2024.Models;
using BCA_III_jan_2024.Providers;
using BCA_III_jan_2024.Repository;
using Dapper;

namespace BCA_III_jan_2024.Forms.IssueForms
{
    public partial class IssueForm : Form
    {
        private BindingList<IssueModel> issueBindingList = new BindingList<IssueModel>();
        private BindingList<AppUser> assignedUserBindingList = new BindingList<AppUser>();
        public IssueForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.AttachEventListeners();

            LoadAssignedUsers();
            
            PerformSearch();
        }

        private void LoadAssignedUsers()
        {
            var userList = UserRepository.GetUsers();
            assignedUserBindingList.Clear();
            foreach (var user in userList)
            {
                assignedUserBindingList.Add(user);
            }

            assignedUserElm.DataSource = assignedUserBindingList;
            assignedUserElm.DisplayMember = nameof(AppUser.Username);
            assignedUserElm.ValueMember = nameof(AppUser.Id);
        }

        private void PerformSearch()
        {
            using (var conn = ConnectionProvider.GetConnection())
            {
                var searchedName = nameElm.Text.Trim();

                var selectedUserId = GetSelectedUserId();
                
                var selectQuery = @"
SELECT i.Id, i.Name, au.Username AS AssignedUser FROM issue  AS i
INNER JOIN app_user AS au ON i.AssignedToUserId = au.Id
WHERE i.Name like @name and ( @assignedUserId IS NULL OR i.AssignedToUserId = @assignedUserId )
";
                var issues = conn.Query<IssueModel>(selectQuery, new
                {
                    name = "%" + searchedName + "%",
                    assignedUserId = selectedUserId
                });
                
                issueBindingList.Clear();
                foreach (var issue in issues)
                {
                    issueBindingList.Add(issue);
                }

                issueListElm.DataSource = issueBindingList;
                issueListElm.Columns["Id"].Visible = false;
            }
        }

        private long? GetSelectedUserId()
        {
            var selected = assignedUserElm.SelectedIndex;
            if (selected < 0) return null;
            return (assignedUserElm.SelectedItem as AppUser).Id;
        }

        private void AttachEventListeners()
        {
            addBtnElm.Click += AddBtnElmOnClick;
            searchBtn.Click += SearchBtnOnClick;
        }

        private void SearchBtnOnClick(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void AddBtnElmOnClick(object sender, EventArgs e)
        {
            this.Hide();
            var form = new IssueAddForm();
            form.ShowDialog();
            this.Show();
            PerformSearch();
        }
    }
}