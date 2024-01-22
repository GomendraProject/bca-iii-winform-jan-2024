using System;
using System.ComponentModel;
using System.Windows.Forms;
using BCA_III_jan_2024.Models;
using BCA_III_jan_2024.Providers;
using Dapper;

namespace BCA_III_jan_2024.Forms
{
    public partial class Dashboard : Form
    {
        private BindingList<AppUser> _bindingUserList = new BindingList<AppUser>();
        public Dashboard()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            userListElm.DataSource = _bindingUserList;
            this.PopulateUserData();
        }

        private void PopulateUserData()
        {
            using (var conn = ConnectionProvider.GetConnection())
            {
                var userListQuery = @"
select * from app_user
";
                var userList = conn.Query<AppUser>(userListQuery, new
                {

                });
                
                _bindingUserList.Clear();
                foreach (var user in userList)
                {
                    _bindingUserList.Add(user);
                }
            }
        }
    }
}
