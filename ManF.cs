using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Winform__with_database_
{
    
    public partial class ManF : Form
    {
        public static int OutputValue = 0;
        DataTable DataList = new DataTable();
        public static string SelectedSorting;
        public ManF()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManF_Load(object sender, EventArgs e)
        {
            ListItemColumn();
            ListItemUpdate();
            ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int RandomNum = DataAccess.Instance.RNGNumber();
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {

                    string Brand = txtBrand.Text; string Type = txtType.Text; int Size = int.Parse(txtSize.Text); string Color = txtColor.Text;
                    int Quantity = int.Parse(txtQua.Text); decimal Price = decimal.Parse(txtPrice.Text);
                    // put command to insert all Column Name into Values
                    string ProductListCheck = "INSERT INTO ProductList (ID, Brand, Type, Color, Size, Quantity, Price) VALUES (@ID, @Brand, @Type, @Color, @Size, @Quantity, @Price)";
                    //Declare class functions to  use the command
                    DataAccess.Instance.InsertProduct(ProductListCheck, RandomNum, Brand, Type, Color, Size, Price, Quantity);
                    txtBrand.Clear(); txtType.Clear(); txtSize.Clear(); txtColor.Clear(); txtPrice.Clear(); txtQua.Clear(); txtID.Clear();
                    ListItemMaF.Items.Clear(); ListItemUpdate();

                }
                else
                {
                    // makes new table for querrycheck 
                    string ProductListCheck = "SELECT * FROM ProductList WHERE ID = '" + int.Parse(txtID.Text) + "'";
                    // the table where the check 
                    DataTable IDCheck = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                    //check if ID does exist
                    if (IDCheck.Rows.Count > 0)
                    {
                        UpdateProductList();
                        txtBrand.Clear(); txtType.Clear(); txtSize.Clear(); txtColor.Clear(); txtPrice.Clear(); txtQua.Clear();txtID.Clear();
                        ListItemMaF.Items.Clear();ListItemUpdate();
                        ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                        ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                        MessageBox.Show("Data Saved", "Saved");
                    }
                    else
                    {
                        MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                txtBrand.Clear(); txtType.Clear(); txtColor.Clear(); txtSize.Clear(); txtPrice.Clear(); txtQua.Clear(); txtID.Clear();
            }
            else
            {
                string ProductListCheck = "DELETE ProductList WHERE ID ='" + int.Parse(txtID.Text) + "'";
                try
                {
                    DataAccess.Instance.UpdateProductList(ProductListCheck);
                    MessageBox.Show("Succesfully Removed", "Delete");
                    txtID.Clear();
                    ListItemMaF.Items.Clear();
                    ListItemUpdate();
                    ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    ListItemMaF.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message, "Error");
                }
            }
        }
        private void CmboSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCmboSorting = this.CmboSorting.GetItemText(this.CmboSorting.SelectedItem);
            SelectedSorting = SelectedCmboSorting;
        }
        private void BtnSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedSorting == "Highest Price Sorting")
                {
                    string ProductListCheck = "SELECT * FROM ProductList ORDER BY Price DESC";
                    ListItemMaF.Items.Clear(); ListItemUpdateCustom(ProductListCheck);
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Lowest Price Sorting")
                {
                    string ProductListCheck = "SELECT * FROM ProductList ORDER BY Price ASC";
                    ListItemMaF.Items.Clear(); ListItemUpdateCustom(ProductListCheck);
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Highest Quantity Sorting")
                {
                    string ProductListCheck = "SELECT * FROM ProductList ORDER BY Quantity DESC";
                    ListItemMaF.Items.Clear(); ListItemUpdateCustom(ProductListCheck);
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Lowest Quantity Sorting")
                {
                    string ProductListCheck = "SELECT * FROM ProductList ORDER BY Quantity ASC";
                    ListItemMaF.Items.Clear(); ListItemUpdateCustom(ProductListCheck);
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Average Price")
                {
                    string ProductListCheck = "SELECT AVG (Price) FROM ProductList";
                    DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                    float ResultDataList = Convert.ToInt64(DataList.Rows[0].ItemArray[0]);
                    ResultDataList = (float)System.Math.Round(ResultDataList, 2); // ResulDataList 0.00
                    MessageBox.Show("€" + ResultDataList, "Average Price", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Total Revenue")
                {
                    string ProductListCheck = "SELECT SUM(Price * Quantity) FROM ProductList";
                    DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                    float ResultDataList = Convert.ToInt64(DataList.Rows[0].ItemArray[0]);
                    ResultDataList = (float)System.Math.Round(ResultDataList, 2); // ResulDataList 0.00
                    MessageBox.Show("€" + string.Format("{0:0.00}", ResultDataList), "Total Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You haven't selected any Custom Selection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }
        private void ListItemMaF_SelectedIndexChanged(object sender, EventArgs e)
        {
            // change textbox same as item selected in listviewitem
            if (ListItemMaF.SelectedItems.Count > 0)
            {
                txtBrand.Text = ListItemMaF.SelectedItems[0].SubItems[1].Text;
                txtType.Text = ListItemMaF.SelectedItems[0].SubItems[2].Text;
                txtColor.Text = ListItemMaF.SelectedItems[0].SubItems[3].Text;
                txtSize.Text = ListItemMaF.SelectedItems[0].SubItems[4].Text;
                txtPrice.Text = ListItemMaF.SelectedItems[0].SubItems[5].Text;
                txtQua.Text = ListItemMaF.SelectedItems[0].SubItems[6].Text;
            }
        }
        // specialized  function for this class only
        public void UpdateProductList()
        {
            string ProductListCheck = "UPDATE ProductList SET Brand = '" + txtBrand.Text + "', Type = '" + txtType.Text + "', Color = '" + txtColor.Text + "', Size = '" + int.Parse(txtSize.Text) + "', Price = '" + decimal.Parse(txtPrice.Text) + "', Quantity = '" + int.Parse(txtQua.Text) + "' WHERE ID = '" + txtID.Text + "'";
            DataAccess.Instance.UpdateProductList(ProductListCheck);
        }
        public void ListItemUpdate()
        {
            ListItemMaF.Items.Clear();
            string ProductListCheck = "SELECT * FROM ProductList";
            DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
            int i;
            // add all items and subitems to listview
            for (i = 0; i <= DataList.Rows.Count - 1; i++)
            {
                ListItemMaF.Items.Add(DataList.Rows[i].ItemArray[0].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[4].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[5].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[6].ToString());
            }
        }
        // List Item Update With custom command
        public void ListItemUpdateCustom(string ProductListCheck)
        {
            ListItemMaF.Items.Clear();
            DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
            // add all items and subitems to listview
            for (int i = 0; i <= DataList.Rows.Count - 1; i++)
            {
                ListItemMaF.Items.Add(DataList.Rows[i].ItemArray[0].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[4].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[5].ToString());
                ListItemMaF.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[6].ToString());
            }
        }

        private void BtnPurchHist_Click(object sender, EventArgs e)
        {
            PurchaseHistory PHForm = new PurchaseHistory();
            this.Hide();
            PHForm.ShowDialog();
            ListItemUpdate();
            this.Show();
           
        }
        public void ListItemColumn()
        {
            ListItemMaF.Columns.Add("ID");
            ListItemMaF.Columns.Add("Brand"); ListItemMaF.Columns.Add("Type"); ListItemMaF.Columns.Add("Color");
            ListItemMaF.Columns.Add("Size"); ListItemMaF.Columns.Add("Price"); ListItemMaF.Columns.Add("Quantity");
            ListItemMaF.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
        }
    }
}
