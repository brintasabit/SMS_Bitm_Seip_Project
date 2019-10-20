using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Bill;
using StockManagementSystem.Model;
namespace StockManagementSystem
{
    public partial class PurchaseModule : Form
    {
        PurchaseManager _purchaseManager=new PurchaseManager();
        Purchase _purchase=new Purchase();
        Product _product=new Product();
        SuppliersPurchase _suppliersPurchase=new SuppliersPurchase();
        public PurchaseModule()
        {
            InitializeComponent();
        }
        
        private void PurchaseModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet1.ProductsPurchase' table. You can move, or remove it, as needed.
           // this.productsPurchaseTableAdapter.Fill(this.stockManagementSystemDataSet1.ProductsPurchase);
           comboBoxSupplier.DataSource = _purchaseManager.ComboBoxSupplierList();
           comboBoxCategory.DataSource = _purchaseManager.ComboBoxCategoryList();
           comboBoxProducts.DataSource = _purchaseManager.ComboBoxProductList(_product);
           
           textBoxCode.Text = Convert.ToString(_purchaseManager.SearchProductCode(_product));
        }

        private void dataGridViewPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPurchase.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _suppliersPurchase.Date = textBoxDate.Text;
                _suppliersPurchase.BillInvoice = textBoxBillInvoice.Text;
                _suppliersPurchase.SupplierName = comboBoxSupplier.Text;
                List<SuppliersPurchase> suppliersPurchases = _purchaseManager.SearchSupplierBill(_suppliersPurchase);
                if (_suppliersPurchase.BillInvoice.Length==0)
                {
                    MessageBox.Show("Can't Add Supplier!");
                }
                else if (suppliersPurchases.Count>0)
                {
                    MessageBox.Show("Bill/Invoice No Exists!");
                }
                else
                {
                    bool isAdded = _purchaseManager.AddSuppliersPurchase(_suppliersPurchase);
                    if (isAdded)
                    {
                        MessageBox.Show("Added!");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

    }
}
