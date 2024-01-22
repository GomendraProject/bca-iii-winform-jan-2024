using BCA_III_jan_2024.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCA_III_jan_2024.Models;
using BCA_III_jan_2024.Providers;
using Dapper;

namespace BCA_III_jan_2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            loginElm.Click += LoginElm_Click;
            registerElm.Click += RegisterElmOnClick;
        }

        private void RegisterElmOnClick(object sender, EventArgs e)
        {
            var registerForm = new UserRegistrationForm();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void LoginElm_Click(object sender, EventArgs e)
        {
            var username = usernameElm.Text;
            var password = passwordElm.Text;

            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input username");
            }
            else if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input password");
            }

            using (var conn = ConnectionProvider.GetConnection())
            {
                var dataCountQuery = @"
SELECT count(*) FROM app_user WHERE Username = @usernamed AND Password = @passwordd
";
                
                // Single Data
                // conn.QueryFirstOrDefault<>()
                
                // List of data
                // conn.Query<int>()
                
                // No Return: INSERT UPDATE DELETE
                // conn.Execute()
                
                var dataCount = conn.QueryFirstOrDefault<int>(dataCountQuery, new
                {
                    usernamed = username,
                    passwordd = password
                });
                
                if(dataCount > 0)
                {
                    var dashboardForm = new Dashboard();
                    this.Hide();
                    dashboardForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }
            }
        }
    }
}
