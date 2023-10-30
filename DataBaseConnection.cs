using Npgsql;
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
            "localhost", 5432, "postgres",
            "password", "mobiledevicestore");
        private NpgsqlConnection connection;

        public DataBaseConnection()
        {
            connection = new NpgsqlConnection(connectionData);
            connection.Open();
        }

        public DataTable GetUserDataByLogin(string login)
        {
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM GetUserByLogin('" + login + "');", connection))
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

        public void AddUser(string login, string password)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT AddUser('" + login + "', '" + password + "');", connection))
            {
                command.ExecuteReader();
            }
        }

        public DataTable LoadProductsTable()
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM ProductsSelect()", connection))
            {
                DataTable dt = new DataTable();
                dt.Load(command.ExecuteReader());
                return dt;
            }
        }

        public void UpdateProductData(Dictionary<string, string> product)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM UpdateTable(" + product["id"] + "::bigint,'"
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
        //public DataTable GetRecordProductByNameOrId(string fieldData)
        //{
        //    using (NpgsqlCommand command = new NpgsqlCommand(@"SELECT * FROM GetRecordByNameOrId('" + fieldData + "'::varchar(100)," + fieldData + ");", connection))
        //    {
        //        DataTable dt = new DataTable();
        //        dt.Load(command.ExecuteReader());
        //        return dt;
        //    }
        //}
    }
}
