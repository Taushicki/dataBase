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
    public partial class mainWindow : Form
    {
        private DataBaseConnection dataBase = new DataBaseConnection();
        private Dictionary<string, string> dicDataProducts = new Dictionary<string, string>();
        private DataTable data;
        
        public mainWindow()
        {
            InitializeComponent();
        }
        private void FillTheFields(Dictionary<string, string> dataProducts)
        {
            FieldName.Text = dataProducts["_name"];
            FieldId.Text = dataProducts["_id"];
            FieldCategory.Text = dataProducts["_category"];
            FieldPrice.Text = dataProducts["_price"];
            FieldCountry.Text = dataProducts["_country"];
            FieldCount.Text = dataProducts["_count"];
        }
        private void ProductTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = ProductTable.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    string columnName = cell.OwningColumn.Name;
                    string cellValue = cell.Value.ToString();
                    dicDataProducts[columnName] = cellValue;
                }
                FillTheFields(dicDataProducts);
            }
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {   
            loginWindow loginWindow = new loginWindow();
            DialogResult result = loginWindow.ShowDialog();
            if (result == DialogResult.Cancel)
                Close();
            data = dataBase.LoadProductsTable();
            ProductTable.DataSource = data;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> productData = new Dictionary<string, string>()
            {
                {"id", FieldId.Text},
                {"category", FieldCategory.Text},
                {"name", FieldName.Text},
                {"country", FieldCountry.Text},
                {"price", FieldPrice.Text},
                {"count", FieldCount.Text}
            };
            dataBase.UpdateProductData(productData);
            ProductTable.DataSource = null;
            data = dataBase.LoadProductsTable();
            ProductTable.DataSource = data;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataBase.DeleteProductData(FieldId.Text);
            ProductTable.DataSource = null;
            data = dataBase.LoadProductsTable();
            ProductTable.DataSource = data;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            LabelWarningProductNF.Visible = false;
            FindButton.Location = new Point(11, 264);

            var foundRow = data.Rows.Cast<DataRow>().FirstOrDefault(row => row["_name"].ToString() == FindField.Text || row["_id"].ToString() == FindField.Text);
            
            if (foundRow != null)
            {
                foreach (DataColumn column in foundRow.Table.Columns)
                {
                    string columnName = column.ColumnName;
                    string columnValue = foundRow[columnName].ToString();
                    dicDataProducts[columnName] = columnValue;
                }

                FillTheFields(dicDataProducts);
            }
            else
            {
                LabelWarningProductNF.Visible = true;
                FindButton.Location = new Point(11, 277);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addRecordWindow addProductWindow = new addRecordWindow();
            DialogResult result = addProductWindow.ShowDialog();
            ProductTable.DataSource = null;

        }
    }
}
