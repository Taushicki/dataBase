﻿using Npgsql;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBase
{
    internal class DataBaseConnection
    {
        private readonly string connectionData = string.Format("Server={0};Port={1};" +
            "User id={2};Password={3};Database={4};",
            "172.20.7.9", 5432, "st1091",
            "pwd1091", "mobiledevice");
        private NpgsqlConnection connection;

        public DataBaseConnection()
        {
            connection = new NpgsqlConnection(connectionData);
            connection.Open();
        }

        public DataTable GetUserDataByLogin(string login)
        {
            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM GetUserByLogin('{ login }');", connection))
            {
                command.Parameters.AddWithValue("login", login);
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable GetSellerDataByUserID(string id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand($"SELECT * FROM GetSellerDataByUserId('{ id }');", connection))
            {
                command.Parameters.AddWithValue("id", id);
                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public void AddSeller(string login, string password)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT AddSeller('" + login + "', '" + password + "');", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public DataTable LoadTable(string TableName)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM " + TableName + "Select();", connection))
            {
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                return dt;
            }
        }

        public void UpdateProductData(Dictionary<string, string> product)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM UpdateProductsTable(" + product["id"] + "::bigint,'"
                + product["category"] + "'::varchar(50),'" + product["name"] + "'::varchar(100),'" + product["country"] + "'::varchar(20),"
                + product["price"] + "::money," + product["count"] + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteProductData(string id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM DeleteData(" + id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void AddProduct(Dictionary<string, string> product)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT AddProduct('" + product["name"] + "'::varchar(100)," +
                "'" + product["category"] + "'::varchar(50),'" + product["country"] + "'::varchar(20),"
                + product["price"] + "::money," + product["count"] + ");", connection)) 
            {
                command.ExecuteNonQuery();
            }
        }

        public void UpdateSellersData(Dictionary<string, string> seller)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM UpdateSellersData(" + seller["Seller id"] + ", '" + seller["Surname"] + "'::varchar(25), '" +
                seller["Name"] + "'::varchar(25), '" + seller["Middle name"] + "'::varchar(25), '" + seller["Post"] + "'::varchar(8), '" +  seller["Passport data"] + "'::varchar(11), '" + seller["ITN"] + "'::varchar(12), '" +
                seller["Phone number"] + "'::varchar(12), '" + seller["Login"] + "'::varchar(25), '" + seller["Password"] + "'::varchar(25), '" + seller["Rights"] + "'::varchar(6));", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteSellerById(string id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM DeleteSellerById(" + id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public string CreateOrder(string seller_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM AddOrder(" + seller_id + "::int" + ");", connection))
            {
                return Convert.ToString(command.ExecuteScalar());
            }
        }

        public void AddProductIntoOrder(string order_id, string product_id, string count)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM AddProductIntoOrder(" + product_id + ", " + order_id + ", " + count + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public DataTable ProductsInOrderSelect(string order_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM ProductsInOrdersSelect(" + order_id + ");", connection))
            {
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                return dt;
            }
        }

        public void DeleteProductFromOrder(string product_id, string order_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM DeleteProductInOrder(" + product_id + ", " + order_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void ChangeOrderSeller(string order_id, string seller_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM ChangeOrderSeller(" + order_id + ", " + seller_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void DeleteOrder(string order_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM DeleteOrder(" + order_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public DataTable GetOrdersBySellerId(string seller_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM OrdersBySeller(" + seller_id + ");", connection))
            {
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                return dt;
            }
        }

        public void CloseOrder(string order_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM CloseOrder(" + order_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void AddProductIntoList(string product_id, string count, string price)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM AddToPurchaseList(" + product_id + ", " + count + ", " + price + "::MONEY);", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void UpdateProductInList(string list_id, string count, string price)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM UpdatePurchaseListItem(" + list_id + ", " + count + ", " + price + "::MONEY);", connection))
            {
                command.ExecuteNonQuery();
            }
        }

        public void CloseList(string list_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM ClosePurchaseList(" + list_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteList(string list_id)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM DeletePurchaseList(" + list_id + ");", connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
