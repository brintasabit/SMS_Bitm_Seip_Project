namespace StockManagementSystem
{
    partial class StockManagementSystemHome
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
            this.ButtonCategory = new System.Windows.Forms.Button();
            this.ButtonProduct = new System.Windows.Forms.Button();
            this.ButtonCustomer = new System.Windows.Forms.Button();
            this.ButtonSupplier = new System.Windows.Forms.Button();
            this.ButtonPurchaseModule = new System.Windows.Forms.Button();
            this.ButtonSalesModule = new System.Windows.Forms.Button();
            this.ButtonStockModuleStock = new System.Windows.Forms.Button();
            this.buttonReportingModuleSales = new System.Windows.Forms.Button();
            this.ButtonReportingModulePurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonCategory
            // 
            this.ButtonCategory.Location = new System.Drawing.Point(32, 104);
            this.ButtonCategory.Name = "ButtonCategory";
            this.ButtonCategory.Size = new System.Drawing.Size(249, 86);
            this.ButtonCategory.TabIndex = 0;
            this.ButtonCategory.Text = "Product Catalog Module (Category)";
            this.ButtonCategory.UseVisualStyleBackColor = true;
            this.ButtonCategory.Click += new System.EventHandler(this.ButtonCategory_Click);
            // 
            // ButtonProduct
            // 
            this.ButtonProduct.Location = new System.Drawing.Point(341, 104);
            this.ButtonProduct.Name = "ButtonProduct";
            this.ButtonProduct.Size = new System.Drawing.Size(249, 86);
            this.ButtonProduct.TabIndex = 1;
            this.ButtonProduct.Text = "Product Catalog Module (Product)";
            this.ButtonProduct.UseVisualStyleBackColor = true;
            this.ButtonProduct.Click += new System.EventHandler(this.ButtonProduct_Click);
            // 
            // ButtonCustomer
            // 
            this.ButtonCustomer.Location = new System.Drawing.Point(624, 104);
            this.ButtonCustomer.Name = "ButtonCustomer";
            this.ButtonCustomer.Size = new System.Drawing.Size(249, 86);
            this.ButtonCustomer.TabIndex = 2;
            this.ButtonCustomer.Text = "Party Module (Customer)";
            this.ButtonCustomer.UseVisualStyleBackColor = true;
            this.ButtonCustomer.Click += new System.EventHandler(this.ButtonCustomer_Click);
            // 
            // ButtonSupplier
            // 
            this.ButtonSupplier.Location = new System.Drawing.Point(933, 104);
            this.ButtonSupplier.Name = "ButtonSupplier";
            this.ButtonSupplier.Size = new System.Drawing.Size(249, 86);
            this.ButtonSupplier.TabIndex = 3;
            this.ButtonSupplier.Text = "Party Module (Supplier)";
            this.ButtonSupplier.UseVisualStyleBackColor = true;
            this.ButtonSupplier.Click += new System.EventHandler(this.ButtonSupplier_Click);
            // 
            // ButtonPurchaseModule
            // 
            this.ButtonPurchaseModule.Location = new System.Drawing.Point(32, 268);
            this.ButtonPurchaseModule.Name = "ButtonPurchaseModule";
            this.ButtonPurchaseModule.Size = new System.Drawing.Size(253, 87);
            this.ButtonPurchaseModule.TabIndex = 4;
            this.ButtonPurchaseModule.Text = "Purchase Module (Purchase)";
            this.ButtonPurchaseModule.UseVisualStyleBackColor = true;
            this.ButtonPurchaseModule.Click += new System.EventHandler(this.ButtonPurchaseModule_Click);
            // 
            // ButtonSalesModule
            // 
            this.ButtonSalesModule.Location = new System.Drawing.Point(341, 268);
            this.ButtonSalesModule.Name = "ButtonSalesModule";
            this.ButtonSalesModule.Size = new System.Drawing.Size(249, 87);
            this.ButtonSalesModule.TabIndex = 5;
            this.ButtonSalesModule.Text = "Sales Module (Sales)";
            this.ButtonSalesModule.UseVisualStyleBackColor = true;
            this.ButtonSalesModule.Click += new System.EventHandler(this.ButtonSalesModule_Click);
            // 
            // ButtonStockModuleStock
            // 
            this.ButtonStockModuleStock.Location = new System.Drawing.Point(624, 268);
            this.ButtonStockModuleStock.Name = "ButtonStockModuleStock";
            this.ButtonStockModuleStock.Size = new System.Drawing.Size(253, 87);
            this.ButtonStockModuleStock.TabIndex = 6;
            this.ButtonStockModuleStock.Text = "Stock Module (Stock)";
            this.ButtonStockModuleStock.UseVisualStyleBackColor = true;
            this.ButtonStockModuleStock.Click += new System.EventHandler(this.ButtonStockModuleStock_Click);
            // 
            // buttonReportingModuleSales
            // 
            this.buttonReportingModuleSales.Location = new System.Drawing.Point(32, 436);
            this.buttonReportingModuleSales.Name = "buttonReportingModuleSales";
            this.buttonReportingModuleSales.Size = new System.Drawing.Size(253, 87);
            this.buttonReportingModuleSales.TabIndex = 6;
            this.buttonReportingModuleSales.Text = "Reporting Module (Sales)";
            this.buttonReportingModuleSales.UseVisualStyleBackColor = true;
            this.buttonReportingModuleSales.Click += new System.EventHandler(this.buttonReportingModuleSales_Click);
            // 
            // ButtonReportingModulePurchase
            // 
            this.ButtonReportingModulePurchase.Location = new System.Drawing.Point(341, 436);
            this.ButtonReportingModulePurchase.Name = "ButtonReportingModulePurchase";
            this.ButtonReportingModulePurchase.Size = new System.Drawing.Size(253, 87);
            this.ButtonReportingModulePurchase.TabIndex = 6;
            this.ButtonReportingModulePurchase.Text = "Reporting Module (Purchase)";
            this.ButtonReportingModulePurchase.UseVisualStyleBackColor = true;
            this.ButtonReportingModulePurchase.Click += new System.EventHandler(this.ButtonReportingModulePurchase_Click);
            // 
            // StockManagementSystemHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 624);
            this.Controls.Add(this.ButtonReportingModulePurchase);
            this.Controls.Add(this.buttonReportingModuleSales);
            this.Controls.Add(this.ButtonStockModuleStock);
            this.Controls.Add(this.ButtonSalesModule);
            this.Controls.Add(this.ButtonPurchaseModule);
            this.Controls.Add(this.ButtonSupplier);
            this.Controls.Add(this.ButtonCustomer);
            this.Controls.Add(this.ButtonProduct);
            this.Controls.Add(this.ButtonCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockManagementSystemHome";
            this.Text = "Stock Management System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCategory;
        private System.Windows.Forms.Button ButtonProduct;
        private System.Windows.Forms.Button ButtonCustomer;
        private System.Windows.Forms.Button ButtonSupplier;
        private System.Windows.Forms.Button ButtonPurchaseModule;
        private System.Windows.Forms.Button ButtonSalesModule;
        private System.Windows.Forms.Button ButtonStockModuleStock;
        private System.Windows.Forms.Button buttonReportingModuleSales;
        private System.Windows.Forms.Button ButtonReportingModulePurchase;
    }
}

