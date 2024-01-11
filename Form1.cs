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

            if(username == "hola" &&  password == "admin")
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
