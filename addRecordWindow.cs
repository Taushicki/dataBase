using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataBase
{
    public partial class addRecordWindow : Form
    {
        private DataBaseConnection dataBase = new DataBaseConnection();
        private Dictionary<string, string> product;
        public addRecordWindow()
        {
            InitializeComponent();
        }
        private bool CheckAvailability()
        {
            DataTable data = dataBase.LoadProductsTable();
            var foundRow = data.Rows.Cast<DataRow>().FirstOrDefault(row => row["_name"].ToString() == product["name"]
            && row["_country"].ToString() == product["country"] && row["_category"].ToString() == product["category"]);

            if (foundRow != null) 
            {
                MessageBox.Show(foundRow.ToString());
                product.Add("id", foundRow["_id"].ToString());
                product["count"] = (int.Parse(product["count"]) + int.Parse(foundRow["_count"].ToString())).ToString();
                return true; 
            }
            else { return false; }
        }

        private void AddButtonAP_Click(object sender, EventArgs e)
        {
            product = new Dictionary<string, string>()
            {
                { "name", NameFieldAP.Text },
                { "category", CategoryFieldAP.Text },
                { "country", CountryFieldAP.Text },
                { "price", PriceFieldAP.Text },
                { "count", CountFieldAP.Text },
            };
            if (CheckAvailability())
            {
                dataBase.UpdateProductData(product);
            }
            else { dataBase.AddProduct(product); }
        }
    }
}
