using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using System.ComponentModel;

namespace Winform__with_database_
{
    internal class DataAccess
    {
        private string connectingString = @"Data Source=ZRoku\SQLEXPRESS;Initial Catalog=Gimpie;Integrated Security=True";
        public static SqlCommand com;
        public static SqlDataAdapter SDA;
        public static DataTable DataList;
        public static SqlDataReader DataReader;
        private static DataAccess instance;
        private static readonly object padlock = new object();
        static DataAccess()
        {
        }

        private DataAccess()
        {
        }

        public static DataAccess Instance
        {
            get
            {
                lock (padlock)
                { 
                    if (instance == null)
                    {
                        instance = new DataAccess();
                    }
                    return instance;
                }
               
            }
        }
        public DataTable ExecuteDataTable(string Query)
        {
            DataList = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(Query, connection))
                {
                    using (SDA = new SqlDataAdapter(com))
                    {
                        SDA.Fill(DataList);

                    }

                }
            }
            return DataList;
        }
        public DataTable ExecuteDataTablPHistory(string PurchaseIDCheck)
        {
            DataList = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(PurchaseIDCheck, connection))
                {
                    using (SDA = new SqlDataAdapter(com))
                    {
                        SDA.Fill(DataList);

                    }

                }
            }
            return DataList;
        }

        public void UpdateUser(string UpdateUser)
        {

            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(UpdateUser, connection))
                {
                    com.ExecuteNonQuery();
                }
            }

        }
        public void UpdateProductList(string UpdateProductList)
        {
            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(UpdateProductList, connection))
                {
                    com.ExecuteNonQuery();
                }
            }

        }
        public void UpdateInsertProductList(string ProductListCheck,int ID, string Brand, string Type, string Color, int Size, decimal Price, int Quantity )
        {

            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(ProductListCheck, connection))
                {
                    try
                    {
                        com.Parameters.AddWithValue("@Brand", Brand);
                        com.Parameters.AddWithValue("@Type", Type);
                        com.Parameters.AddWithValue("@Color", Color);
                        com.Parameters.AddWithValue("@Size", Size);
                        com.Parameters.AddWithValue("@Price", Price);
                        com.Parameters.AddWithValue("@Quantity", Quantity);
                        com.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }

                }

            }

        }
        public void InsertUser(string UserInsertCheck, string Password, string Username, string Role, int RandomNum)
        {
            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(UserInsertCheck, connection))
                {
                    com.Parameters.AddWithValue("@Username", Username);
                    com.Parameters.AddWithValue("@Password", Password);
                    com.Parameters.AddWithValue("@Role", Role);
                    com.Parameters.AddWithValue("@ID", RandomNum);
                    int a = com.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Saved", "Saved", MessageBoxButtons.OK);
                    }
                }
            }
        }
        public void InsertProduct(string ProductListCheck,int RandomNum, string Brand, string Type, string Color, int Size, decimal Price, int Quantity)
        {
            using (SqlConnection connection = new SqlConnection(connectingString))
            {
                connection.Open();
                using (com = new SqlCommand(ProductListCheck, connection))
                {
                    com.Parameters.AddWithValue("@ID", RandomNum);
                    com.Parameters.AddWithValue("@Brand", Brand);
                    com.Parameters.AddWithValue("@Type", Type);
                    com.Parameters.AddWithValue("@Color", Color);
                    com.Parameters.AddWithValue("@Size", Size);
                    com.Parameters.AddWithValue("@Price", Price);
                    com.Parameters.AddWithValue("@Quantity", Quantity);
                    int a = com.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Data Saved");
                    }
                }
            }
        }
        public int RNGNumber()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1000, 9999);
            string Query = "SELECT * FROM PurchaseHistory WHERE PurchaseID = '" + RandomNumber + "'";
            DataTable DataList = DataAccess.Instance.ExecuteDataTable(Query);
            while (DataList.Rows.Count > 0)
            {
                RandomNumber = rnd.Next(1000, 9999);
                DataList = DataAccess.Instance.ExecuteDataTable(Query);
            }
            return RandomNumber;

        }
    }
}
