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
        private bool addInOrder;
        public ProductsListWindow(string orderId, bool addInOrder)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.addInOrder = addInOrder;
        }

        private void ProductsListWindow_Load(object sender, EventArgs e)
        {
            ProductsListProductsTable.DataSource = null;
            ProductsListProductsTable.DataSource = dataBase.LoadTable("Products");
            if (!addInOrder)
            {
                textBox1.Visible = true;
                label2.Visible = true;
            }
        }

        private void ProductsListButtonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(productId))
            {
                if (addInOrder)
                {
                    dataBase.AddProductIntoOrder(orderId, productId, ProductListComboBoxCount.Text);
                }
                else
                {
                    dataBase.AddProductIntoList(productId, ProductListComboBoxCount.Text, textBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("Select an product!");
            }
                
            
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
