namespace dataBase
{
    partial class addRecordWindow
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
            this.AddProductPanel = new System.Windows.Forms.Panel();
            this.AddButtonAP = new System.Windows.Forms.Button();
            this.CancelButtonAP = new System.Windows.Forms.Button();
            this.NameFieldAP = new System.Windows.Forms.TextBox();
            this.CategoryFieldAP = new System.Windows.Forms.TextBox();
            this.CountryFieldAP = new System.Windows.Forms.TextBox();
            this.PriceFieldAP = new System.Windows.Forms.TextBox();
            this.CountFieldAP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNameAP = new System.Windows.Forms.Label();
            this.LAbelPriceAP = new System.Windows.Forms.Label();
            this.LabelCountAP = new System.Windows.Forms.Label();
            this.LabelCountryAP = new System.Windows.Forms.Label();
            this.LabelCategoryAP = new System.Windows.Forms.Label();
            this.AddProductPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddProductPanel
            // 
            this.AddProductPanel.Controls.Add(this.LabelCategoryAP);
            this.AddProductPanel.Controls.Add(this.LabelCountryAP);
            this.AddProductPanel.Controls.Add(this.LabelCountAP);
            this.AddProductPanel.Controls.Add(this.LAbelPriceAP);
            this.AddProductPanel.Controls.Add(this.LabelNameAP);
            this.AddProductPanel.Controls.Add(this.label1);
            this.AddProductPanel.Controls.Add(this.CountFieldAP);
            this.AddProductPanel.Controls.Add(this.PriceFieldAP);
            this.AddProductPanel.Controls.Add(this.CountryFieldAP);
            this.AddProductPanel.Controls.Add(this.CategoryFieldAP);
            this.AddProductPanel.Controls.Add(this.NameFieldAP);
            this.AddProductPanel.Controls.Add(this.CancelButtonAP);
            this.AddProductPanel.Controls.Add(this.AddButtonAP);
            this.AddProductPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddProductPanel.Location = new System.Drawing.Point(0, 0);
            this.AddProductPanel.Name = "AddProductPanel";
            this.AddProductPanel.Size = new System.Drawing.Size(384, 661);
            this.AddProductPanel.TabIndex = 0;
            // 
            // AddButtonAP
            // 
            this.AddButtonAP.Location = new System.Drawing.Point(123, 531);
            this.AddButtonAP.Name = "AddButtonAP";
            this.AddButtonAP.Size = new System.Drawing.Size(125, 40);
            this.AddButtonAP.TabIndex = 0;
            this.AddButtonAP.Text = "Add";
            this.AddButtonAP.UseVisualStyleBackColor = true;
            this.AddButtonAP.Click += new System.EventHandler(this.AddButtonAP_Click);
            // 
            // CancelButtonAP
            // 
            this.CancelButtonAP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButtonAP.Location = new System.Drawing.Point(123, 577);
            this.CancelButtonAP.Name = "CancelButtonAP";
            this.CancelButtonAP.Size = new System.Drawing.Size(125, 40);
            this.CancelButtonAP.TabIndex = 1;
            this.CancelButtonAP.Text = "Cancel";
            this.CancelButtonAP.UseVisualStyleBackColor = true;
            // 
            // NameFieldAP
            // 
            this.NameFieldAP.Location = new System.Drawing.Point(88, 100);
            this.NameFieldAP.Name = "NameFieldAP";
            this.NameFieldAP.Size = new System.Drawing.Size(200, 20);
            this.NameFieldAP.TabIndex = 2;
            // 
            // CategoryFieldAP
            // 
            this.CategoryFieldAP.Location = new System.Drawing.Point(88, 185);
            this.CategoryFieldAP.Name = "CategoryFieldAP";
            this.CategoryFieldAP.Size = new System.Drawing.Size(200, 20);
            this.CategoryFieldAP.TabIndex = 3;
            // 
            // CountryFieldAP
            // 
            this.CountryFieldAP.Location = new System.Drawing.Point(88, 270);
            this.CountryFieldAP.Name = "CountryFieldAP";
            this.CountryFieldAP.Size = new System.Drawing.Size(200, 20);
            this.CountryFieldAP.TabIndex = 4;
            // 
            // PriceFieldAP
            // 
            this.PriceFieldAP.Location = new System.Drawing.Point(88, 355);
            this.PriceFieldAP.Name = "PriceFieldAP";
            this.PriceFieldAP.Size = new System.Drawing.Size(200, 20);
            this.PriceFieldAP.TabIndex = 5;
            // 
            // CountFieldAP
            // 
            this.CountFieldAP.Location = new System.Drawing.Point(88, 440);
            this.CountFieldAP.Name = "CountFieldAP";
            this.CountFieldAP.Size = new System.Drawing.Size(200, 20);
            this.CountFieldAP.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(128, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Add Product";
            // 
            // LabelNameAP
            // 
            this.LabelNameAP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelNameAP.AutoSize = true;
            this.LabelNameAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameAP.Location = new System.Drawing.Point(155, 75);
            this.LabelNameAP.Name = "LabelNameAP";
            this.LabelNameAP.Size = new System.Drawing.Size(64, 25);
            this.LabelNameAP.TabIndex = 8;
            this.LabelNameAP.Text = "Name";
            this.LabelNameAP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAbelPriceAP
            // 
            this.LAbelPriceAP.AutoSize = true;
            this.LAbelPriceAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LAbelPriceAP.Location = new System.Drawing.Point(162, 330);
            this.LAbelPriceAP.Name = "LAbelPriceAP";
            this.LAbelPriceAP.Size = new System.Drawing.Size(56, 25);
            this.LAbelPriceAP.TabIndex = 9;
            this.LAbelPriceAP.Text = "Price";
            // 
            // LabelCountAP
            // 
            this.LabelCountAP.AutoSize = true;
            this.LabelCountAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountAP.Location = new System.Drawing.Point(156, 415);
            this.LabelCountAP.Name = "LabelCountAP";
            this.LabelCountAP.Size = new System.Drawing.Size(65, 25);
            this.LabelCountAP.TabIndex = 10;
            this.LabelCountAP.Text = "Count";
            // 
            // LabelCountryAP
            // 
            this.LabelCountryAP.AutoSize = true;
            this.LabelCountryAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCountryAP.Location = new System.Drawing.Point(150, 245);
            this.LabelCountryAP.Name = "LabelCountryAP";
            this.LabelCountryAP.Size = new System.Drawing.Size(81, 25);
            this.LabelCountryAP.TabIndex = 11;
            this.LabelCountryAP.Text = "Country";
            // 
            // LabelCategoryAP
            // 
            this.LabelCategoryAP.AutoSize = true;
            this.LabelCategoryAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCategoryAP.Location = new System.Drawing.Point(143, 160);
            this.LabelCategoryAP.Name = "LabelCategoryAP";
            this.LabelCategoryAP.Size = new System.Drawing.Size(92, 25);
            this.LabelCategoryAP.TabIndex = 12;
            this.LabelCategoryAP.Text = "Category";
            // 
            // addRecordWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.AddProductPanel);
            this.Name = "addRecordWindow";
            this.Text = "addRecordWindow";
            this.AddProductPanel.ResumeLayout(false);
            this.AddProductPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AddProductPanel;
        private System.Windows.Forms.Button AddButtonAP;
        private System.Windows.Forms.TextBox NameFieldAP;
        private System.Windows.Forms.Button CancelButtonAP;
        private System.Windows.Forms.TextBox CategoryFieldAP;
        private System.Windows.Forms.TextBox PriceFieldAP;
        private System.Windows.Forms.TextBox CountryFieldAP;
        private System.Windows.Forms.TextBox CountFieldAP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelCategoryAP;
        private System.Windows.Forms.Label LabelCountryAP;
        private System.Windows.Forms.Label LabelCountAP;
        private System.Windows.Forms.Label LAbelPriceAP;
        private System.Windows.Forms.Label LabelNameAP;
    }
}