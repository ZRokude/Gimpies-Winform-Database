using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform__with_database_
{
    public partial class AdminF2 : Form
    {
        DataTable DataList;
        string SelectedRole;
        int IDRole = Convert.ToInt32(Login.IDRole);

        public AdminF2()
        {
            InitializeComponent();
        }

        private void AdminF2_Load(object sender, EventArgs e)
        {
            ListItemColumn();
            ListItemUpdate();
            ListItemAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemAccount.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void cmboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCmboRole = this.cmboRole.GetItemText(this.cmboRole.SelectedItem);
            SelectedRole = SelectedCmboRole;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int RandomNum = rnd.Next(0, 9999);

            // Insert the datatable DataUser 
            string UserInsertCheck = "INSERT INTO DataUser (ID, Role, Username, Password) VALUES (@ID, @Role, @Username, @Password)";
            string UserCheck = ("SELECT * FROM DataUser WHERE Username = '" + txtUser.Text + "'");
           
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || SelectedRole == null)
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    // function to execute command to database
                    DataTable UserCheckResult = DataAccess.Instance.ExecuteDataTable(UserCheck);
                    //checking if there is same username
                    if (UserCheckResult.Rows.Count > 0)
                    {
                        MessageBox.Show("Username is already exist, please use another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string Password = txtPass.Text; string Username = txtUser.Text; string Role = SelectedRole;
                        //function to insert into database
                        DataAccess.Instance.InsertUser(UserInsertCheck, Password, Username, Role, RandomNum);
                        //clear and update function
                        txtUser.Clear(); txtPass.Clear();
                        ListItemAccount.Items.Clear();
                        ListItemUpdate();
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            try
            {
                // makes new table for querrycheck 
                string UserCheck = "SELECT * FROM DataUser WHERE ID = '" + int.Parse(txtID.Text) + "'";
                DataList = DataAccess.Instance.ExecuteDataTable(UserCheck);
                //check if ID does exist
                if (DataList.Rows.Count > 0)
                {
                    if (int.Parse(txtID.Text) == IDRole)
                    {
                        MessageBox.Show("Invalid ID Input Login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string UpdateUser = "DELETE DataUser WHERE ID ='" + int.Parse(txtID.Text) + "'";
                        DataAccess.Instance.UpdateUser(UpdateUser);
                        MessageBox.Show("Succesfully Removed", "Delete");
                        txtID.Clear();
                        ListItemAccount.Items.Clear();
                        ListItemUpdate();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Invalid ID Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtID.Clear();
                }
            }
            catch
            {
                MessageBox.Show("You should put the correct syntax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListItemUpdate()
        {
            string UserCheck = "SELECT * FROM DataUser";
            // put the data to the listview
            DataList = DataAccess.Instance.ExecuteDataTable(UserCheck);
            // add all items and subitems to listview
            for (int i = 0; i <= DataList.Rows.Count - 1; i++)
            {
                ListItemAccount.Items.Add(DataList.Rows[i].ItemArray[0].ToString());
                ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
                ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
            }
        }

        private void ListItemAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ListItemColumn()
        {
            ListItemAccount.Columns.Add("ID"); ListItemAccount.Columns.Add("Role");
            ListItemAccount.Columns.Add("Username"); ListItemAccount.Columns.Add("Password");
            ListItemAccount.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
        }
    }
}
