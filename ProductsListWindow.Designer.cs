namespace dataBase
{
    partial class ProductsListWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductsListProductsTable = new System.Windows.Forms.DataGridView();
            this.ProductsListButtonAdd = new System.Windows.Forms.Button();
            this.ProductListComboBoxCount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsListButtonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsListProductsTable
            // 
            this.ProductsListProductsTable.AllowUserToAddRows = false;
            this.ProductsListProductsTable.AllowUserToDeleteRows = false;
            this.ProductsListProductsTable.AllowUserToResizeRows = false;
            this.ProductsListProductsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsListProductsTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsListProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsListProductsTable.Location = new System.Drawing.Point(12, 12);
            this.ProductsListProductsTable.Name = "ProductsListProductsTable";
            this.ProductsListProductsTable.RowHeadersVisible = false;
            this.ProductsListProductsTable.Size = new System.Drawing.Size(776, 317);
            this.ProductsListProductsTable.TabIndex = 0;
            this.ProductsListProductsTable.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductsListProductsTable_CellMouseClick);
            // 
            // ProductsListButtonAdd
            // 
            this.ProductsListButtonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ProductsListButtonAdd.Location = new System.Drawing.Point(509, 394);
            this.ProductsListButtonAdd.Name = "ProductsListButtonAdd";
            this.ProductsListButtonAdd.Size = new System.Drawing.Size(137, 44);
            this.ProductsListButtonAdd.TabIndex = 1;
            this.ProductsListButtonAdd.Text = "Add";
            this.ProductsListButtonAdd.UseVisualStyleBackColor = true;
            this.ProductsListButtonAdd.Click += new System.EventHandler(this.ProductsListButtonAdd_Click);
            // 
            // ProductListComboBoxCount
            // 
            this.ProductListComboBoxCount.FormattingEnabled = true;
            this.ProductListComboBoxCount.Location = new System.Drawing.Point(12, 357);
            this.ProductListComboBoxCount.Name = "ProductListComboBoxCount";
            this.ProductListComboBoxCount.Size = new System.Drawing.Size(165, 21);
            this.ProductListComboBoxCount.TabIndex = 2;
            this.ProductListComboBoxCount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Count:";
            // 
            // ProductsListButtonClose
            // 
            this.ProductsListButtonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ProductsListButtonClose.Location = new System.Drawing.Point(652, 394);
            this.ProductsListButtonClose.Name = "ProductsListButtonClose";
            this.ProductsListButtonClose.Size = new System.Drawing.Size(137, 44);
            this.ProductsListButtonClose.TabIndex = 4;
            this.ProductsListButtonClose.Text = "Close";
            this.ProductsListButtonClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 411);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // ProductsListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductsListButtonClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductListComboBoxCount);
            this.Controls.Add(this.ProductsListButtonAdd);
            this.Controls.Add(this.ProductsListProductsTable);
            this.Name = "ProductsListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsListWindow";
            this.Load += new System.EventHandler(this.ProductsListWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsListProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsListProductsTable;
        private System.Windows.Forms.Button ProductsListButtonAdd;
        private System.Windows.Forms.ComboBox ProductListComboBoxCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ProductsListButtonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}