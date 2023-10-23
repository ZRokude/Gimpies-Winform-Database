using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Winform__with_database_
{
    public partial class Login : Form
    {
        public static string role, IDRole;
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = usernameInput.Text;
            password = passwordInput.Text;
            int LoginAttempt = 0;
            try
            {
                
                string UserCheck = "SELECT * FROM DataUser WHERE Username = '" + usernameInput.Text + "' AND Password = '" + passwordInput.Text + "'";
                DataTable UserCheckResult = DataAccess.Instance.ExecuteDataTable(UserCheck);
                if (UserCheckResult.Rows.Count > 0 )
                {
                    role = Convert.ToString(UserCheckResult.Rows[0].ItemArray[1]);
                    IDRole = Convert.ToString(UserCheckResult.Rows[0].ItemArray[0]);
                    usernameInput.Clear();passwordInput.Clear();
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else if (LoginAttempt >= 3)
                {
                    MessageBox.Show("You have 3 times try to Login, Wait for another 5 Minutes to retry", "Error");
                    btnLogin.Enabled = false;
                    System.Threading.Thread.Sleep(30000);
                }
                else
                {
                    LoginAttempt++;
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    usernameInput.Clear();
                    passwordInput.Clear();

                    // back to username

                    usernameInput.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
