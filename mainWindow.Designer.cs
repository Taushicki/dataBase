namespace dataBase
{
    partial class mainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductTable = new System.Windows.Forms.DataGridView();
            this.AdminToolsPanel = new System.Windows.Forms.Panel();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.LabelWarningProductNF = new System.Windows.Forms.Label();
            this.InfroPanelAdmin = new System.Windows.Forms.Panel();
            this.LabelCount = new System.Windows.Forms.Label();
            this.LabelCountry = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelId = new System.Windows.Forms.Label();
            this.FieldCountry = new System.Windows.Forms.TextBox();
            this.FieldPrice = new System.Windows.Forms.TextBox();
            this.FieldCount = new System.Windows.Forms.TextBox();
            this.FieldCategory = new System.Windows.Forms.TextBox();
            this.FieldId = new System.Windows.Forms.TextBox();
            this.FieldName = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelProduct = new System.Windows.Forms.Label();
            this.AddToOrderButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.FindField = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.UsersPage = new System.Windows.Forms.TabPage();
            this.UsersTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).BeginInit();
            this.AdminToolsPanel.SuspendLayout();
            this.InfroPanelAdmin.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ProductsPage.SuspendLayout();
            this.UsersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductTable
            // 
            this.ProductTable.AllowUserToAddRows = false;
            this.ProductTable.AllowUserToDeleteRows = false;
            this.ProductTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ProductTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductTable.Location = new System.Drawing.Point(0, 0);
            this.ProductTable.Margin = new System.Windows.Forms.Padding(0);
            this.ProductTable.MultiSelect = false;
            this.ProductTable.Name = "ProductTable";
            this.ProductTable.ReadOnly = true;
            this.ProductTable.RowHeadersWidth = 51;
            this.ProductTable.RowTemplate.Height = 24;
            this.ProductTable.Size = new System.Drawing.Size(1126, 750);
            this.ProductTable.TabIndex = 0;
            this.ProductTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductTable_CellMouseClick);
            // 
            // AdminToolsPanel
            // 
            this.AdminToolsPanel.Controls.Add(this.AddProductButton);
            this.AdminToolsPanel.Controls.Add(this.LabelWarningProductNF);
            this.AdminToolsPanel.Controls.Add(this.InfroPanelAdmin);
            this.AdminToolsPanel.Controls.Add(this.AddToOrderButton);
            this.AdminToolsPanel.Controls.Add(this.FindButton);
            this.AdminToolsPanel.Controls.Add(this.FindField);
            this.AdminToolsPanel.Controls.Add(this.DeleteButton);
            this.AdminToolsPanel.Controls.Add(this.EditButton);
            this.AdminToolsPanel.Location = new System.Drawing.Point(4, 6);
            this.AdminToolsPanel.Name = "AdminToolsPanel";
            this.AdminToolsPanel.Size = new System.Drawing.Size(336, 843);
            this.AdminToolsPanel.TabIndex = 1;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(11, 92);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddProductButton.Size = new System.Drawing.Size(306, 23);
            this.AddProductButton.TabIndex = 9;
            this.AddProductButton.Text = "Add new product";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // LabelWarningProductNF
            // 
            this.LabelWarningProductNF.AutoSize = true;
            this.LabelWarningProductNF.ForeColor = System.Drawing.Color.Red;
            this.LabelWarningProductNF.Location = new System.Drawing.Point(115, 261);
            this.LabelWarningProductNF.Name = "LabelWarningProductNF";
            this.LabelWarningProductNF.Size = new System.Drawing.Size(101, 13);
            this.LabelWarningProductNF.TabIndex = 8;
            this.LabelWarningProductNF.Text = "Product not found!!!";
            this.LabelWarningProductNF.Visible = false;
            // 
            // InfroPanelAdmin
            // 
            this.InfroPanelAdmin.BackColor = System.Drawing.SystemColors.Control;
            this.InfroPanelAdmin.Controls.Add(this.LabelCount);
            this.InfroPanelAdmin.Controls.Add(this.LabelCountry);
            this.InfroPanelAdmin.Controls.Add(this.LabelPrice);
            this.InfroPanelAdmin.Controls.Add(this.LabelCategory);
            this.InfroPanelAdmin.Controls.Add(this.LabelId);
            this.InfroPanelAdmin.Controls.Add(this.FieldCountry);
            this.InfroPanelAdmin.Controls.Add(this.FieldPrice);
            this.InfroPanelAdmin.Controls.Add(this.FieldCount);
            this.InfroPanelAdmin.Controls.Add(this.FieldCategory);
            this.InfroPanelAdmin.Controls.Add(this.FieldId);
            this.InfroPanelAdmin.Controls.Add(this.FieldName);
            this.InfroPanelAdmin.Controls.Add(this.LabelName);
            this.InfroPanelAdmin.Controls.Add(this.LabelProduct);
            this.InfroPanelAdmin.Location = new System.Drawing.Point(11, 306);
            this.InfroPanelAdmin.Name = "InfroPanelAdmin";
            this.InfroPanelAdmin.Size = new System.Drawing.Size(306, 405);
            this.InfroPanelAdmin.TabIndex = 7;
            // 
            // LabelCount
            // 
            this.LabelCount.AutoSize = true;
            this.LabelCount.Location = new System.Drawing.Point(10, 340);
            this.LabelCount.Name = "LabelCount";
            this.LabelCount.Size = new System.Drawing.Size(38, 13);
            this.LabelCount.TabIndex = 12;
            this.LabelCount.Text = "Count:";
            // 
            // LabelCountry
            // 
            this.LabelCountry.AutoSize = true;
            this.LabelCountry.Location = new System.Drawing.Point(7, 280);
            this.LabelCountry.Name = "LabelCountry";
            this.LabelCountry.Size = new System.Drawing.Size(46, 13);
            this.LabelCountry.TabIndex = 11;
            this.LabelCountry.Text = "Country:";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(7, 220);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(34, 13);
            this.LabelPrice.TabIndex = 10;
            this.LabelPrice.Text = "Price:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.LabelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategory.Location = new System.Drawing.Point(7, 160);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(58, 15);
            this.LabelCategory.TabIndex = 9;
            this.LabelCategory.Text = "Category:";
            // 
            // LabelId
            // 
            this.LabelId.AutoSize = true;
            this.LabelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelId.Location = new System.Drawing.Point(7, 100);
            this.LabelId.Name = "LabelId";
            this.LabelId.Size = new System.Drawing.Size(20, 15);
            this.LabelId.TabIndex = 8;
            this.LabelId.Text = "id:";
            // 
            // FieldCountry
            // 
            this.FieldCountry.Location = new System.Drawing.Point(7, 300);
            this.FieldCountry.MaxLength = 20;
            this.FieldCountry.Name = "FieldCountry";
            this.FieldCountry.Size = new System.Drawing.Size(288, 20);
            this.FieldCountry.TabIndex = 7;
            // 
            // FieldPrice
            // 
            this.FieldPrice.Location = new System.Drawing.Point(7, 240);
            this.FieldPrice.Name = "FieldPrice";
            this.FieldPrice.Size = new System.Drawing.Size(288, 20);
            this.FieldPrice.TabIndex = 6;
            // 
            // FieldCount
            // 
            this.FieldCount.Location = new System.Drawing.Point(7, 360);
            this.FieldCount.Name = "FieldCount";
            this.FieldCount.Size = new System.Drawing.Size(288, 20);
            this.FieldCount.TabIndex = 5;
            // 
            // FieldCategory
            // 
            this.FieldCategory.Location = new System.Drawing.Point(7, 180);
            this.FieldCategory.MaxLength = 50;
            this.FieldCategory.Name = "FieldCategory";
            this.FieldCategory.Size = new System.Drawing.Size(288, 20);
            this.FieldCategory.TabIndex = 4;
            // 
            // FieldId
            // 
            this.FieldId.Location = new System.Drawing.Point(7, 120);
            this.FieldId.Name = "FieldId";
            this.FieldId.ReadOnly = true;
            this.FieldId.Size = new System.Drawing.Size(288, 20);
            this.FieldId.TabIndex = 3;
            // 
            // FieldName
            // 
            this.FieldName.Location = new System.Drawing.Point(7, 60);
            this.FieldName.MaxLength = 100;
            this.FieldName.Name = "FieldName";
            this.FieldName.Size = new System.Drawing.Size(288, 20);
            this.FieldName.TabIndex = 2;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(4, 40);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(44, 15);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name:";
            // 
            // LabelProduct
            // 
            this.LabelProduct.AutoSize = true;
            this.LabelProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelProduct.Location = new System.Drawing.Point(122, 12);
            this.LabelProduct.Name = "LabelProduct";
            this.LabelProduct.Size = new System.Drawing.Size(60, 18);
            this.LabelProduct.TabIndex = 0;
            this.LabelProduct.Text = "Product";
            // 
            // AddToOrderButton
            // 
            this.AddToOrderButton.Location = new System.Drawing.Point(11, 717);
            this.AddToOrderButton.Name = "AddToOrderButton";
            this.AddToOrderButton.Size = new System.Drawing.Size(306, 23);
            this.AddToOrderButton.TabIndex = 6;
            this.AddToOrderButton.Text = "Add to order";
            this.AddToOrderButton.UseVisualStyleBackColor = true;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(11, 261);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(306, 23);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindField
            // 
            this.FindField.Location = new System.Drawing.Point(11, 238);
            this.FindField.Name = "FindField";
            this.FindField.Size = new System.Drawing.Size(306, 20);
            this.FindField.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(167, 746);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 30);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(11, 746);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(150, 30);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ProductsPage);
            this.tabControl1.Controls.Add(this.UsersPage);
            this.tabControl1.Location = new System.Drawing.Point(346, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1134, 776);
            this.tabControl1.TabIndex = 2;
            // 
            // ProductsPage
            // 
            this.ProductsPage.Controls.Add(this.ProductTable);
            this.ProductsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductsPage.Location = new System.Drawing.Point(4, 22);
            this.ProductsPage.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(1126, 750);
            this.ProductsPage.TabIndex = 0;
            this.ProductsPage.Text = "Products";
            this.ProductsPage.UseVisualStyleBackColor = true;
            // 
            // UsersPage
            // 
            this.UsersPage.Controls.Add(this.UsersTable);
            this.UsersPage.Location = new System.Drawing.Point(4, 22);
            this.UsersPage.Name = "UsersPage";
            this.UsersPage.Padding = new System.Windows.Forms.Padding(3);
            this.UsersPage.Size = new System.Drawing.Size(1126, 750);
            this.UsersPage.TabIndex = 1;
            this.UsersPage.Text = "Users";
            this.UsersPage.UseVisualStyleBackColor = true;
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToAddRows = false;
            this.UsersTable.AllowUserToDeleteRows = false;
            this.UsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.UsersTable.BackgroundColor = System.Drawing.Color.White;
            this.UsersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersTable.Location = new System.Drawing.Point(3, 3);
            this.UsersTable.Margin = new System.Windows.Forms.Padding(0);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.Size = new System.Drawing.Size(1120, 744);
            this.UsersTable.TabIndex = 0;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.AdminToolsPanel);
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductTable)).EndInit();
            this.AdminToolsPanel.ResumeLayout(false);
            this.AdminToolsPanel.PerformLayout();
            this.InfroPanelAdmin.ResumeLayout(false);
            this.InfroPanelAdmin.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ProductsPage.ResumeLayout(false);
            this.UsersPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductTable;
        private System.Windows.Forms.Panel AdminToolsPanel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox FindField;
        private System.Windows.Forms.Button AddToOrderButton;
        private System.Windows.Forms.Panel InfroPanelAdmin;
        private System.Windows.Forms.Label LabelId;
        private System.Windows.Forms.TextBox FieldCountry;
        private System.Windows.Forms.TextBox FieldPrice;
        private System.Windows.Forms.TextBox FieldCount;
        private System.Windows.Forms.TextBox FieldCategory;
        private System.Windows.Forms.TextBox FieldId;
        private System.Windows.Forms.TextBox FieldName;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelProduct;
        private System.Windows.Forms.Label LabelCount;
        private System.Windows.Forms.Label LabelCountry;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelWarningProductNF;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage UsersPage;
        private System.Windows.Forms.DataGridView UsersTable;
    }
}

