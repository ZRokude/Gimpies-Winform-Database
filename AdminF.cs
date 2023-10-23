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
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;

namespace Winform__with_database_
{
    public partial class AdminF : Form
    {
        //SqlConnection connect = new SqlConnection(@"Data Source=ZRoku\SQLEXPRESS;Initial Catalog=Gimpie;Integrated Security=True");
        //SqlCommand com;
        //DataTable DataList;
        //SqlDataAdapter SDA = new SqlDataAdapter();
        //DataSet DS;
        public AdminF()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void AdminF_Load(object sender, EventArgs e)
        {
            ListItemUpdate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Random rnd = new Random();
            //int RandomNum = rnd.Next(0, 9999);

            //// Insert the datatable DataUser 
            //com = new SqlCommand("INSERT INTO DataUser (ID, Role, Username, Password) VALUES (@ID, @Role, @Username, @Password)", connect);

            ////com.CommandType = CommandType.StoredProcedure;
            //// add item to all tables item
            //connect.Open();
            //com.Parameters.AddWithValue("@Username", txtUser.Text);
            //com.Parameters.AddWithValue("@Password", txtPass.Text);
            //com.Parameters.AddWithValue("@Role", getRole());
            //com.Parameters.AddWithValue("@ID", RandomNum);

            //// connect to the database

            //int a = com.ExecuteNonQuery();
            //connect.Close();
            //if (a > 0)
            //{
            //    MessageBox.Show("Data Saved");
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
            //txtUser.Clear(); txtPass.Clear();
            //ListItemAccount.Items.Clear();
            //ListItemUpdate();
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            //connect.Open();

            //com = new SqlCommand("DELETE DataUser WHERE ID ='" + int.Parse(txtID.Text) + "'", connect);
            //com.ExecuteNonQuery();
            //connect.Close();
            //MessageBox.Show("Succesfully Removed", "Delete");
            //txtID.Clear();
            //ListItemAccount.Items.Clear();
            //ListItemUpdate();
        }
        public void ListItemUpdate()
        {
            
            //// connect to the database
            //connect.Open();
            //// select the datatable ListShoes  
            //com = new SqlCommand("SELECT * FROM DataUser", connect);
            //SDA = new SqlDataAdapter(com);
            //DS = new DataSet();
            //// put and set the data to adapter
            //SDA.Fill(DS, "ListItemAccount");
            //// close connection
            //connect.Close();
            //// put the data to the listview
            //DataList = DS.Tables["ListItemAccount"];
            //int i;
            //// add all items and subitems to listview
            //for (i = 0; i <= DataList.Rows.Count - 1; i++)
            //{
            //    ListItemAccount.Items.Add(DataList.Rows[i].ItemArray[0].ToString());
            //    ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
            //    ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
            //    ListItemAccount.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
            //}
        }
        public String getRole()
        {
            if (rdbtnAdmin.Checked == true)
            {
                return "Administrator";
            }
            else if (rdbtnManager.Checked == true)
            {
                return "Manager";
            }
            else
            {
                return "User";
            }
        }
        private void ListItemAccount_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnManager_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbtnUser_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
