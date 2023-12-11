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

    
    public partial class ProductsListWindow : Form
    {
        private DataBaseConnection dataBase = new DataBaseConnection();
        private string orderId;
        private string productId;
        public ProductsListWindow(string orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
        }

        private void ProductsListWindow_Load(object sender, EventArgs e)
        {
            ProductsListProductsTable.DataSource = null;
            ProductsListProductsTable.DataSource = dataBase.LoadTable("Products");
        }

        private void ProductsListButtonAdd_Click(object sender, EventArgs e)
        {
            dataBase.AddProductIntoOrder(orderId, productId, ProductListComboBoxCount.Text);
        }

        private void ProductsListProductsTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ProductsListProductsTable.Rows[e.RowIndex];
                productId = selectedRow.Cells["_id"].Value.ToString();
                ProductListComboBoxCount.Items.Clear();
                for (int i = 1; i <= Convert.ToInt32(selectedRow.Cells["_count"].Value); i++)
                {
                    ProductListComboBoxCount.Items.Add(i);
                }
            }
        }
    }
}
