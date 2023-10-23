using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform__with_database_
{
    public partial class PurchaseHistory : Form
    {
        public static DataTable DataList;
        public string SelectedSorting;
        public PurchaseHistory()
        {
            InitializeComponent();
        }
        
        public void ListItemUpdate()
        {
            ListItemPHistory.Items.Clear();

            string PurchaseIDCheck = "SELECT * FROM PurchaseHistory";
            DataList = DataAccess.Instance.ExecuteDataTable(PurchaseIDCheck);
            int i;
            // add all items and subitems to listview
            for (i = 0; i <= DataList.Rows.Count - 1; i++)
            {
                ListItemPHistory.Items.Add(DataList.Rows[i].ItemArray[0].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[2].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[3].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[4].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[5].ToString());
            }
        }
        public void ListItemUpdateSorting(string ProductListCheck)
        {
            ListItemPHistory.Items.Clear();
            DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
            // add all items and subitems to listview
            for (int i = 0; i <= DataList.Rows.Count - 1; i++)
            {
                ListItemPHistory.Items.Add("");
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[0].ToString());
                ListItemPHistory.Items[i].SubItems.Add(DataList.Rows[i].ItemArray[1].ToString());
                ListItemPHistory.Items[i].SubItems.Add("");
                ListItemPHistory.Items[i].SubItems.Add("");

                
            }
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            ListItemColumn();
            ListItemUpdate();
            ListItemPHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemPHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            ListItemPHistory.Columns.Clear();
            ListItemPHistory.Items.Clear();
            ListItemColumn();
            ListItemUpdate();
            ListItemPHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListItemPHistory.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string PurchaseIDCheck= "SELECT * FROM PurchaseHistory WHERE PurchaseID = '" + int.Parse(txtID.Text) + "'";
                DataList = DataAccess.Instance.ExecuteDataTable(PurchaseIDCheck);
                if (DataList.Rows.Count > 0)
                {
                    string RemoveHistory = "DELETE PurchaseHistory WHERE PurchaseID = '" + int.Parse(txtID.Text) + "'";
                    DataAccess.Instance.UpdateProductList(RemoveHistory);
                    ListItemUpdate();
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ID is Invalid, Please Put the Corred ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListItemPHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListItemPHistory.SelectedItems.Count > 0)
            {
                txtID.Text = ListItemPHistory.SelectedItems[0].SubItems[4].Text;
            }
        }

        private void BtnDD_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedSorting == "Highest Sell")
                {
                    string ProductListCheck = "SELECT ProductID, SUM(Quantity) AS TotalQuantity FROM PurchaseHistory GROUP BY ProductID ORDER BY TotalQuantity DESC";
                    ListItemUpdateSorting(ProductListCheck);
                }
                else if (SelectedSorting == "Lowest Sell")
                {
                    string ProductListCheck = "SELECT ProductID, SUM(Quantity) AS TotalQuantity FROM PurchaseHistory GROUP BY ProductID ORDER BY TotalQuantity ASC";
                    ListItemUpdateSorting(ProductListCheck);
                }
                else if (SelectedSorting == "Total Ammount Sell")
                {
                    string ProductListCheck = "SELECT SUM(Quantity) FROM PurchaseHistory";
                    DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                    MessageBox.Show(DataList.Rows[0].ItemArray[0].ToString() + "Ammount", "Total Sell", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (SelectedSorting == "Total Revenue")
                {
                    string ProductListCheck = "SELECT SUM(Quantity * Price) FROM PurchaseHistory";
                    DataList = DataAccess.Instance.ExecuteDataTable(ProductListCheck);
                    MessageBox.Show("€" + DataList.Rows[0].ItemArray[0].ToString(), "Total Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CmboSorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCmboSorting = this.CmboSorting.GetItemText(this.CmboSorting.SelectedItem);
            SelectedSorting = SelectedCmboSorting;
        }
        public void ListItemColumn()
        {
            ListItemPHistory.Columns.Add("UserID"); ListItemPHistory.Columns.Add("ProductID"); ListItemPHistory.Columns.Add("Quantity");
            ListItemPHistory.Columns.Add("Price"); ListItemPHistory.Columns.Add("PurchaseID"); ListItemPHistory.Columns.Add("Paid");
            ListItemPHistory.Font = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
        }
    }
}
