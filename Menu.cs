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
using System.Runtime.Remoting.Messaging;

namespace Winform__with_database_
{
    public partial class Menu : Form
    {
        DataTable DataList;
        public const string messageC = "Are you sure want to proceed?";
        public const string Title = "Gimpies";

        public Menu()
        {
            InitializeComponent();
        }

        public void Menu_Load(object sender, EventArgs e)
        {

            // change text
            txtRole.Text = "Role: " + Login.role;
            ListItemColumn();
            ListItemUpdate();
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (Login.role == "Administrator")
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false && btnAdmin.Visible == false && btnManagerF.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true; btnAdmin.Visible = true; btnManagerF.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true && btnAdmin.Visible == true && btnManagerF.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false; btnAdmin.Visible = false; btnManagerF.Visible = false;
                }
            }
            else if (Login.role == "Manager")
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false && btnManagerF.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true; btnManagerF.Visible = true; btnManagerF.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true && btnManagerF.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false; btnAdmin.Visible = false; btnManagerF.Visible = false;
                }
            }
            else if (Login.role == "User")
            {
                if (btnAcc.Visible == false && btnLogO.Visible == false)
                {
                    btnLogO.Visible = true; btnAcc.Visible = true;
                }
                else if (btnAcc.Visible == true && btnLogO.Visible == true)
                {
                    btnLogO.Visible = false; btnAcc.Visible = false;
                }
            }
        }

        private void btnManagerF_Click(object sender, EventArgs e)
        {
            ManF ManFForm = new ManF();
            this.Hide();
            ManFForm.ShowDialog();
            ListItemMen.Items.Clear();
            ListItemColumn();
            ListItemUpdate();
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Show();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminF2 AdminForm = new AdminF2();
            this.Hide();
            AdminForm.ShowDialog();
            ListItemMen.Items.Clear();
            ListItemColumn();
            ListItemUpdate();
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Show();

        }

        private void btnLogO_Click(object sender, EventArgs e)
        {
            var LogO = MessageBox.Show(messageC, Title, MessageBoxButtons.OKCancel);

            if (LogO == DialogResult.OK)
            {
                this.Close();

            }
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            Account AccForm = new Account();
            this.Hide();
            AccForm.ShowDialog();
            ListItemColumn();
            ListItemUpdate();
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemMen.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            this.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            try
            {
                // string query for command sql
                string ProductListCheck = "SELECT * FROM ProductList WHERE Brand = '" + txtBrand.Text + "' AND Type = '" + txtType.Text + "' AND Color = '" + txtColor.Text + "' AND Size = '" + int.Parse(txtSize.Text) + "'";

                // table math operator that has return value inside dataaccess class function
                DataTable ProductListResult = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                //check if ID does exist
                if (ProductListResult.Rows.Count > 0)
                {
                    int i = Convert.ToInt32(ProductListResult.Rows[0].ItemArray[6]);
                    int txtQuaRemove = Convert.ToInt32(txtQuantity.Text);
                    string UpdateProductList = "UPDATE ProductList SET Quantity = Quantity - '" + txtQuantity.Text + "'  WHERE Brand = '" + txtBrand.Text + "' AND Type = '" + txtType.Text + "' AND Color = '" + txtColor.Text + "' AND Size = '" + int.Parse(txtSize.Text) + "'";

                    //reopen the database
                    if (i - txtQuaRemove > 0)
                    {
                        DataAccess.Instance.UpdateProductList(UpdateProductList);
                        //succesfully updated message
                        MessageBox.Show("Succesfully updated", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //refresh listitem
                        txtBrand.Clear(); txtType.Clear(); txtColor.Clear(); txtSize.Clear(); txtQuantity.Clear();
                        ListItemMen.Items.Clear();
                        ListItemUpdate();
                    }
                    else
                    {
                        txtBrand.Clear();txtType.Clear();txtColor.Clear();txtSize.Clear(); txtQuantity.Clear();
                        MessageBox.Show("Invalid Quantity Number Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else // option if you put invalid syntax of quantity or ID
                {
                    txtBrand.Clear(); txtType.Clear(); txtColor.Clear(); txtSize.Clear(); txtQuantity.Clear();
                    MessageBox.Show("Invalid Item or Quantity Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                txtBrand.Clear(); txtType.Clear(); txtColor.Clear(); txtSize.Clear(); txtQuantity.Clear();
                MessageBox.Show("You should put the correct syntax", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEx_Click_1(object sender, EventArgs e)
        {
            var LogO = MessageBox.Show(messageC, Title,
                            MessageBoxButtons.OKCancel);
            if (LogO == DialogResult.OK)
            {
                Environment.Exit(0);
            }

        }
        // Function specialized in this class
        public void ListItemUpdate()
        {
            string ProductListCheck = "SELECT * FROM ProductList";
            DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
            
            for (int i = 0; i < 6 - 1; i++)
            {
                ListItemMen.Items.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemMen.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
                ListItemMen.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
                ListItemMen.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[4].ToString());
                ListItemMen.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[5].ToString());
                ListItemMen.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[6].ToString());
               
            }
        }

        private void ListItemMen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListItemMen.SelectedItems.Count > 0)
            {
                txtBrand.Text = ListItemMen.SelectedItems[0].SubItems[0].Text;
                txtType.Text = ListItemMen.SelectedItems[0].SubItems[1].Text;
                txtColor.Text = ListItemMen.SelectedItems[0].SubItems[2].Text;
                txtSize.Text = ListItemMen.SelectedItems[0].SubItems[3].Text;
            }
        }
        public void ListItemColumn()
        {
            ListItemMen.Columns.Add("Brand"); ListItemMen.Columns.Add("Type"); ListItemMen.Columns.Add("Color");
            ListItemMen.Columns.Add("Size"); ListItemMen.Columns.Add("Price"); ListItemMen.Columns.Add("Quantity");
            ListItemMen.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
        }
    }
}


