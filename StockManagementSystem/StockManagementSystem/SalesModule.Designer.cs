namespace StockManagementSystem
{
    partial class SalesModule
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
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxLoyalityPoint = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.textBoxTotalMrp = new System.Windows.Forms.TextBox();
            this.textBoxMRP = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxAvailableQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.textBoxPayableAmount = new System.Windows.Forms.TextBox();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxGrandTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.stockManagementSystemDataSet2 = new StockManagementSystem.StockManagementSystemDataSet2();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new StockManagementSystem.StockManagementSystemDataSet2TableAdapters.SalesTableAdapter();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLoyalityPoint);
            this.groupBox2.Controls.Add(this.textBoxDate);
            this.groupBox2.Controls.Add(this.comboBoxCustomer);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer";
            // 
            // textBoxLoyalityPoint
            // 
            this.textBoxLoyalityPoint.Location = new System.Drawing.Point(210, 120);
            this.textBoxLoyalityPoint.Name = "textBoxLoyalityPoint";
            this.textBoxLoyalityPoint.Size = new System.Drawing.Size(121, 26);
            this.textBoxLoyalityPoint.TabIndex = 2;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(210, 77);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 26);
            this.textBoxDate.TabIndex = 2;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(210, 25);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCustomer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loyality Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ButtonAdd);
            this.groupBox3.Controls.Add(this.textBoxTotalMrp);
            this.groupBox3.Controls.Add(this.textBoxMRP);
            this.groupBox3.Controls.Add(this.textBoxQuantity);
            this.groupBox3.Controls.Add(this.textBoxAvailableQuantity);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.comboBoxProduct);
            this.groupBox3.Controls.Add(this.comboBoxCategory);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 214);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(399, 380);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Product";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(247, 324);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(104, 35);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxTotalMrp
            // 
            this.textBoxTotalMrp.Location = new System.Drawing.Point(201, 263);
            this.textBoxTotalMrp.Name = "textBoxTotalMrp";
            this.textBoxTotalMrp.Size = new System.Drawing.Size(150, 26);
            this.textBoxTotalMrp.TabIndex = 2;
            // 
            // textBoxMRP
            // 
            this.textBoxMRP.Location = new System.Drawing.Point(201, 211);
            this.textBoxMRP.Name = "textBoxMRP";
            this.textBoxMRP.Size = new System.Drawing.Size(150, 26);
            this.textBoxMRP.TabIndex = 2;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(201, 165);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(150, 26);
            this.textBoxQuantity.TabIndex = 2;
            // 
            // textBoxAvailableQuantity
            // 
            this.textBoxAvailableQuantity.Location = new System.Drawing.Point(201, 116);
            this.textBoxAvailableQuantity.Name = "textBoxAvailableQuantity";
            this.textBoxAvailableQuantity.Size = new System.Drawing.Size(150, 26);
            this.textBoxAvailableQuantity.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total MRP (Tk)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "MRP (Tk)";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(201, 70);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(150, 28);
            this.comboBoxProduct.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(201, 25);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(150, 28);
            this.comboBoxCategory.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Available Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ButtonSubmit);
            this.groupBox4.Controls.Add(this.textBoxPayableAmount);
            this.groupBox4.Controls.Add(this.textBoxDiscountAmount);
            this.groupBox4.Controls.Add(this.dataGridViewSales);
            this.groupBox4.Controls.Add(this.textBoxDiscount);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.textBoxGrandTotal);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(441, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(744, 582);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Details";
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(505, 526);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(91, 34);
            this.ButtonSubmit.TabIndex = 4;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            // 
            // textBoxPayableAmount
            // 
            this.textBoxPayableAmount.Location = new System.Drawing.Point(363, 465);
            this.textBoxPayableAmount.Name = "textBoxPayableAmount";
            this.textBoxPayableAmount.Size = new System.Drawing.Size(233, 26);
            this.textBoxPayableAmount.TabIndex = 2;
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(363, 413);
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(233, 26);
            this.textBoxDiscountAmount.TabIndex = 2;
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AutoGenerateColumns = false;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.productDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn,
            this.totalMRPDataGridViewTextBoxColumn,
            this.Action});
            this.dataGridViewSales.DataSource = this.salesBindingSource;
            this.dataGridViewSales.Location = new System.Drawing.Point(17, 30);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.RowTemplate.Height = 28;
            this.dataGridViewSales.Size = new System.Drawing.Size(711, 252);
            this.dataGridViewSales.TabIndex = 0;
            this.dataGridViewSales.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSales_RowPostPaint);
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(363, 367);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(233, 26);
            this.textBoxDiscount.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(149, 465);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Payable Amount (Tk)";
            // 
            // textBoxGrandTotal
            // 
            this.textBoxGrandTotal.Location = new System.Drawing.Point(363, 318);
            this.textBoxGrandTotal.Name = "textBoxGrandTotal";
            this.textBoxGrandTotal.Size = new System.Drawing.Size(233, 26);
            this.textBoxGrandTotal.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 416);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Discount Amount (Tk)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Grand Total (Tk)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Discount (%)";
            // 
            // stockManagementSystemDataSet2
            // 
            this.stockManagementSystemDataSet2.DataSetName = "StockManagementSystemDataSet2";
            this.stockManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this.stockManagementSystemDataSet2;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "Product";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            // 
            // totalMRPDataGridViewTextBoxColumn
            // 
            this.totalMRPDataGridViewTextBoxColumn.DataPropertyName = "TotalMRP";
            this.totalMRPDataGridViewTextBoxColumn.HeaderText = "TotalMRP";
            this.totalMRPDataGridViewTextBoxColumn.Name = "totalMRPDataGridViewTextBoxColumn";
            // 
            // Action
            // 
            this.Action.DataPropertyName = "Product";
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Width = 168;
            // 
            // SalesModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 626);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SalesModule";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.SalesModule_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxLoyalityPoint;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox textBoxTotalMrp;
        private System.Windows.Forms.TextBox textBoxMRP;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxAvailableQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox textBoxPayableAmount;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxGrandTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private StockManagementSystemDataSet2 stockManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private StockManagementSystemDataSet2TableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMRPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
    }
}