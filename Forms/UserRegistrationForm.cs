using System;
using System.Windows.Forms;
using BCA_III_jan_2024.Providers;
using Dapper;

namespace BCA_III_jan_2024.Forms
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
            this.Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.AttachEventListeners();
        }

        private void AttachEventListeners()
        {
            registerButton.Click += RegisterButtonOnClick;
        }

        private void RegisterButtonOnClick(object sender, EventArgs e)
        {
            try
            {
                var username = usernameElm.Text.Trim();
                var password = passwordElm.Text.Trim();
                var confirmPassword = this.confirmPassword.Text.Trim();

                if (password.Length < 5)
                {
                    throw new Exception("Invalid password. Password must be at least 5 characters long");
                }

                if (password != confirmPassword)
                {
                    throw new Exception("Password and confirm password do not match");
                }

                using (var conn = ConnectionProvider.GetConnection())
                {
                    var insertQuery = @"INSERT INTO app_user
(
`Username`,
`Password`,
`Status`)
VALUES
(
@username,
@password,
@status)";
                    conn.Execute(insertQuery, new
                    {
                        username = username,
                        password = password,
                        status = "ACTIVE"
                    });
                    MessageBox.Show("User registration completed");
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