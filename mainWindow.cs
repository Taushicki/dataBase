using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum TabPageSelected
{
    PRODUCTS,
    SELLER,
    ORDER,
    PURCHASE_LIST
}

namespace dataBase
{
    
    public partial class mainWindow : Form
    {
        private DataBaseConnection dataBase = new DataBaseConnection();
        private Dictionary<string, string> dicDataProducts = new Dictionary<string, string>();
        private Dictionary<string, string> dicDataSellers = new Dictionary<string, string>();
        private Dictionary<string, string> dicDataOrders = new Dictionary<string, string>();
        private DataTable userData;
        private DataTable tableProducts;
        private DataTable tableSellers;
        private DataTable tableOrders;
        private DataTable tableProductsInOrder;
        private DataTable sellerData;
        private Panel currentToolsPanel;
        private string selectedProductIdInOrder;
        private string userId;
        private string userRights;
        private bool rowIsSelected;
        
        private TabPageSelected previosTabPage;
        

        public mainWindow()
        {
            InitializeComponent();
            
        }
        private void CreateLabel(DataRow dataSeller)
        {
            Label labelSurname = new Label();
            Label labelName = new Label();
            Label labelMiddleName = new Label();
            labelSurname.Text = dataSeller["Surname"].ToString();
            labelName.Text = dataSeller["Name"].ToString();
            labelMiddleName.Text = dataSeller["Middle name"].ToString();
            labelSurname.Font = new System.Drawing.Font("Arial", 12);
            labelName.Font = new System.Drawing.Font("Arial", 12);
            labelMiddleName.Font = new System.Drawing.Font("Arial", 12);
            labelSurname.Location = new System.Drawing.Point(89, 18);
            labelName.Location = new System.Drawing.Point(69, 45);
            labelMiddleName.Location = new System.Drawing.Point(113, 76);
            UserDataPanel.Controls.Add(labelSurname);
            UserDataPanel.Controls.Add(labelName);
            UserDataPanel.Controls.Add(labelMiddleName);
        }
        private void FillTheProductFields(Dictionary<string, string> dataProduct)
        {
            AdminProductFieldName.Text = dataProduct["_name"];
            AdminProductFieldId.Text = dataProduct["_id"];
            AdminProductFieldCategory.Text = dataProduct["_category"];
            AdminProductFieldPrice.Text = dataProduct["_price"];
            AdminProductFieldCountry.Text = dataProduct["_country"];
            AdminProductFieldCount.Text = dataProduct["_count"];
        }

        private void FillTheSellerFields(Dictionary<string, string> dataSeller)
        {
            AdminSellerFieldId.Text = dataSeller["Seller id"];
            AdminSellerFieldName.Text = dataSeller["Name"];
            AdminSellerFieldSurname.Text = dataSeller["Surname"];
            AdminSellerFieldMiddleName.Text = dataSeller["Middle name"];
            AdminSellerComboBoxPost.Text = dataSeller["Post"];
            AdminSellerFieldPassportData.Text = dataSeller["Passport data"];
            AdminSellerFieldItn.Text = dataSeller["ITN"];
            AdminSellerFieldPhoneNumber.Text = dataSeller["Phone number"];
            AdminSellerFieldLogin.Text = dataSeller["Login"];
            AdminSellerFieldPassword.Text = dataSeller["Password"];
            AdminSellerComboBoxRights.Text = dataSeller["Rights"];
        }

        private void FillTheOrderFields(Dictionary<string, string> dataOrder)
        {
            AdminOrderFieldId.Text = dataOrder["Order id"];
            DataTable OrderSellerData = dataBase.GetSellerDataByUserID(dataOrder["Seller id"]);
            AdminOrderComboBoxSellersName.Text = OrderSellerData.Rows[0]["Name"].ToString() + " " + OrderSellerData.Rows[0]["Middle name"].ToString();
            AdminOrderFieldPrice.Text = dataOrder["Price"];
            AdminOrderFieldDate.Text = dataOrder["Date"];
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {   
            loginWindow loginWindow = new loginWindow();
            DialogResult result = loginWindow.ShowDialog();
            if (result != DialogResult.OK)
                Close();
            else
            {
                userId = loginWindow.userId.ToString();
                
                userData = dataBase.GetSellerDataByUserID(userId);
                userRights = userData.Rows[0]["Rights"].ToString();
                CreateLabel(userData.Rows[0]);
                tableProducts = dataBase.LoadTable("Products");
                ProductTable.DataSource = tableProducts;
                currentToolsPanel = AdminProductToolsPanel;
                previosTabPage = TabControlState(TabControlAdmin);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> productData = new Dictionary<string, string>()
            {
                {"id", AdminProductFieldId.Text},
                {"category", AdminProductFieldCategory.Text},
                {"name", AdminProductFieldName.Text},
                {"country", AdminProductFieldCountry.Text},
                {"price", AdminProductFieldPrice.Text},
                {"count", AdminProductFieldCount.Text}
            };
            dataBase.UpdateProductData(productData);
            ProductTable.DataSource = null;
            tableProducts = dataBase.LoadTable("Products");
            ProductTable.DataSource = tableProducts;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            dataBase.DeleteProductData(AdminProductFieldId.Text);
            ProductTable.DataSource = null;
            tableProducts = dataBase.LoadTable("Products");
            ProductTable.DataSource = tableProducts;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            AdminProductLabelWarningProductNF.Visible = false;
            AdminProductFindButton.Location = new Point(11, 58);

            var foundRow = tableProducts.Rows.Cast<DataRow>().FirstOrDefault(row => row["_name"].ToString() == AdminProductFindField.Text || row["_id"].ToString() == AdminProductFindField.Text);
            
            if (foundRow != null)
            {
                foreach (DataColumn column in foundRow.Table.Columns)
                {
                    string columnName = column.ColumnName;
                    string columnValue = foundRow[columnName].ToString();
                    dicDataProducts[columnName] = columnValue;
                }

                FillTheProductFields(dicDataProducts);
            }
            else
            {
                AdminProductLabelWarningProductNF.Visible = true;
                AdminProductFindButton.Location = new Point(11, 72);
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            addRecordWindow addProductWindow = new addRecordWindow();
            DialogResult result = addProductWindow.ShowDialog();
            ProductTable.DataSource = null;

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
                FillTheProductFields(dicDataProducts);
            }
        }
        private TabPageSelected TabControlState(TabControl TabControlAdmin)
        {
            switch (TabControlAdmin.SelectedIndex)
            {
                case 1:
                    return TabPageSelected.SELLER;
                case 2:
                    return TabPageSelected.ORDER;
                case 3:
                    return TabPageSelected.PURCHASE_LIST;
                default:
                    break;
            }
            return TabPageSelected.PRODUCTS;
        }
        private void AdminTabControl_MouseClick(object sender, MouseEventArgs e)
        {
            TabPageSelected tabPage = TabControlState(TabControlAdmin);
            if (tabPage == TabPageSelected.PRODUCTS)
            {
                this.Controls.Remove(currentToolsPanel);
                this.Controls.Add(AdminProductToolsPanel);
                currentToolsPanel = AdminProductToolsPanel;
                AdminProductToolsPanel.Visible = true;
                previosTabPage = tabPage;
                tableProducts = dataBase.LoadTable("Products");
                ProductTable.DataSource = tableProducts;

            }
            if (tabPage == TabPageSelected.SELLER)
            {
                this.Controls.Remove(currentToolsPanel);
                this.Controls.Add(AdminSellerToolsPanel);
                currentToolsPanel = AdminSellerToolsPanel;
                AdminSellerToolsPanel.Visible = true;
                tableSellers = dataBase.LoadTable("Sellers");
                SellersTable.DataSource = tableSellers;
                SellersTable.Columns["Login"].Visible = false;
                SellersTable.Columns["Password"].Visible = false;
                SellersTable.Columns["Rights"].Visible = false;
            }
            if (tabPage == TabPageSelected.ORDER)
            {
                this.Controls.Remove(currentToolsPanel);
                this.Controls.Add(AdminOrderToolsPanel);
                currentToolsPanel = AdminOrderToolsPanel;
                AdminOrderToolsPanel.Visible = true;
                previosTabPage= tabPage;
                tableOrders = dataBase.LoadTable("Orders");
                OrdersTable.DataSource = tableOrders;
            }

        }

        private void SellersTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = SellersTable.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    string columnName = cell.OwningColumn.Name;
                    string cellValue = cell.Value.ToString();
                    dicDataSellers[columnName] = cellValue;
                }
                FillTheSellerFields(dicDataSellers);
            }
        }

        private void AdminSellerEditButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> sellerData = new Dictionary<string, string>()
            {
                {"Seller id", AdminSellerFieldId.Text},
                {"Name", AdminSellerFieldName.Text},
                {"Surname", AdminSellerFieldSurname.Text},
                {"Middle name", AdminSellerFieldMiddleName.Text},
                {"Post", AdminSellerComboBoxPost.Text},
                {"Passport data", AdminSellerFieldPassportData.Text},
                {"ITN", AdminSellerFieldItn.Text},
                {"Phone number", AdminSellerFieldPhoneNumber.Text},
                {"Login", AdminSellerFieldLogin.Text},
                {"Password", AdminSellerFieldPassword.Text},
                {"Rights", AdminSellerComboBoxRights.Text}
            };

            dataBase.UpdateSellersData(sellerData);
            SellersTable.DataSource = null;
            tableSellers = dataBase.LoadTable("Sellers");
            SellersTable.DataSource = tableSellers;
            SellersTable.Columns["Login"].Visible = false;
            SellersTable.Columns["Password"].Visible = false;
            SellersTable.Columns["Rights"].Visible = false;
        }

        private void UserDataPanel_MouseClick(object sender, MouseEventArgs e)
        {
            userData = dataBase.GetSellerDataByUserID(userId);
            userWindow userWindow = new userWindow(userData, userId, userRights);
            DialogResult result = userWindow.ShowDialog();
            SellersTable.DataSource = null;
            tableSellers = dataBase.LoadTable("Sellers");
            SellersTable.DataSource = tableSellers;
            SellersTable.Columns["Login"].Visible = false;
            SellersTable.Columns["Password"].Visible = false;
            SellersTable.Columns["Rights"].Visible = false;

        }

        private void AdminSellerDeleteButton_Click(object sender, EventArgs e)
        {
            if (userId != AdminSellerFieldId.Text)
            {
                dataBase.DeleteSellerById(AdminSellerFieldId.Text);
                SellersTable.DataSource = null;
                tableSellers = dataBase.LoadTable("Sellers");
                SellersTable.DataSource = tableSellers;
                SellersTable.Columns["Login"].Visible = false;
                SellersTable.Columns["Password"].Visible = false;
                SellersTable.Columns["Rights"].Visible = false;
            }
            else
            {
                MessageBox.Show("You can not remove yourself!!!");
            }
            
        }

        private void AdminSellerFindButton_Click(object sender, EventArgs e)
        {
            AdminSellerLabelWarning.Visible = false;
            AdminSellerFindButton.Location = new Point(11, 32);

            var foundRow = tableSellers.Rows.Cast<DataRow>().FirstOrDefault(row => row["Seller Id"].ToString() == AdminSellerFindField.Text || row["Login"].ToString() == AdminSellerFindField.Text);

            if (foundRow != null)
            {
                foreach (DataColumn column in foundRow.Table.Columns)
                {
                    string columnName = column.ColumnName;
                    string columnValue = foundRow[columnName].ToString();
                    dicDataSellers[columnName] = columnValue;
                }
                FillTheSellerFields(dicDataSellers);
            }
            else
            {
                AdminSellerLabelWarning.Visible = true;
                AdminSellerFindButton.Location = new Point(11, 46);
            }
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            dataBase.CreateOrder(userId);
            OrdersTable.DataSource = null;
            tableOrders = dataBase.LoadTable("Orders");
            OrdersTable.DataSource = tableOrders;
        }

        private void OrdersTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = OrdersTable.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    string columnName = cell.OwningColumn.Name;
                    string cellValue = cell.Value.ToString();
                    dicDataOrders[columnName] = cellValue;
                }
                rowIsSelected = false;
                FillTheOrderFields(dicDataOrders);
                tableProductsInOrder = dataBase.ProductsInOrderSelect(AdminOrderFieldId.Text);
                ProductsInOrderTable.DataSource = tableProductsInOrder;
            }
        }

        private void AdminOrderButtonAddProduct_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminOrderFieldId.Text))
            {
                MessageBox.Show("Select an order");
            }
            else
            {
                ProductsListWindow productsListWindow = new ProductsListWindow(AdminOrderFieldId.Text);
                DialogResult result = productsListWindow.ShowDialog();
                tableOrders = dataBase.LoadTable("Orders");
                OrdersTable.DataSource = tableOrders;
                tableProductsInOrder = dataBase.ProductsInOrderSelect(AdminOrderFieldId.Text);
                ProductsInOrderTable.DataSource = tableProductsInOrder;
            }
            
        }
        private void AdminOrderButtonCloseOrder_Click(object sender, EventArgs e)
        {

        }
        private void ProductsInOrderTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = ProductsInOrderTable.Rows[e.RowIndex];
                selectedProductIdInOrder = selectedRow.Cells["Product id"].Value.ToString();
            }
            rowIsSelected = true;
        }
        private void AdminOrderButtonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (rowIsSelected)
            {
                dataBase.DeleteProductFromOrder(selectedProductIdInOrder, AdminOrderFieldId.Text);
                tableOrders = dataBase.LoadTable("Orders");
                OrdersTable.DataSource = tableOrders;
                tableProductsInOrder = dataBase.ProductsInOrderSelect(AdminOrderFieldId.Text);
                ProductsInOrderTable.DataSource = tableProductsInOrder;
            }
            else
            {
                MessageBox.Show("Select an product");
            }
        }
    }
}

