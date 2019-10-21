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
        private int serialNo = 2020;
        private void PurchaseModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet1.ProductsPurchase' table. You can move, or remove it, as needed.
           // this.productsPurchaseTableAdapter.Fill(this.stockManagementSystemDataSet1.ProductsPurchase);
           comboBoxSupplier.DataSource = _purchaseManager.ComboBoxSupplierList();
           comboBoxCategory.DataSource = _purchaseManager.ComboBoxCategoryList();
           comboBoxProducts.DataSource = _purchaseManager.ComboBoxProductList(_product);
           dataGridViewPurchase.DataSource = _purchaseManager.ShowPurchases(_purchase);
           serialNo--;
           textBoxCode.Text = serialNo.ToString();

            //textBoxCode.Text = Convert.ToString(_purchaseManager.SearchProductCode(_product));
        }

        private void dataGridViewPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPurchase.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _purchase.Date = textBoxDate.Text;
                _purchase.BillInvoice = textBoxBillInvoice.Text;
                _purchase.SupplierName = comboBoxSupplier.Text;
                _purchase.Category = comboBoxCategory.Text;
                _purchase.Products = comboBoxProducts.Text;
                _purchase.Code = textBoxCode.Text;
                _purchase.AvailableQuantity = Convert.ToInt32(textBoxAvailableQuantity.Text);
                _purchase.ManufacturedDate = textBoxManufacturedDate.Text;
                _purchase.ExpireDate = textBoxExpireDate.Text;
                _purchase.Remarks = textBoxRemarks.Text;
                _purchase.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                _purchase.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                textBoxTotalPrice.Text=Convert.ToString(_purchase.Quantity * _purchase.UnitPrice);
                _purchase.TotalPrice = Convert.ToDouble(textBoxTotalPrice.Text);
                _purchase.PreviousUnitPrice = Convert.ToDouble(textBoxPreviousUnitPrice.Text);
                _purchase.PreviousMRP=Convert.ToDouble(textBoxPreviousMrp.Text);
                textBoxMrp.Text=Convert.ToString(_purchase.UnitPrice + ((25 * _purchase.UnitPrice) / 100));
                _purchase.MRP = Convert.ToDouble(textBoxMrp.Text);
                _purchase.Profit = _purchase.UnitPrice - _purchase.MRP;
                List<Purchase> purchasesCode = _purchaseManager.SearchPurchasesCode(_purchase);
                List<Purchase> purchasesBill = _purchaseManager.SearchSupplierBill(_purchase);
                if (purchasesBill.Count>0)
                {
                    MessageBox.Show("Bill-Invoice No. Exists!");
                }
                else if (purchasesCode.Count>0)
                {
                    MessageBox.Show("Purchase Code Exists!");
                    serialNo--;
                    textBoxCode.Text = serialNo.ToString();
                }
                else
                {
                    
                    MessageBox.Show("Added!");
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            //serialNo--;
            //textBoxCode.Text = serialNo.ToString();
            try
            {
                _purchase.Date = textBoxDate.Text;
                _purchase.BillInvoice = textBoxBillInvoice.Text;
                _purchase.SupplierName = comboBoxSupplier.Text;
                _purchase.Category = comboBoxCategory.Text;
                _purchase.Products = comboBoxProducts.Text;
                _purchase.Code = textBoxCode.Text;
                _purchase.AvailableQuantity = Convert.ToInt32(textBoxAvailableQuantity.Text);
                _purchase.ManufacturedDate = textBoxManufacturedDate.Text;
                _purchase.ExpireDate = textBoxExpireDate.Text;
                _purchase.Remarks = textBoxRemarks.Text;
                _purchase.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                _purchase.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                textBoxTotalPrice.Text=Convert.ToString(_purchase.Quantity * _purchase.UnitPrice);
                _purchase.TotalPrice = Convert.ToDouble(textBoxTotalPrice.Text);
                _purchase.PreviousUnitPrice = Convert.ToDouble(textBoxPreviousUnitPrice.Text);
                _purchase.PreviousMRP=Convert.ToDouble(textBoxPreviousMrp.Text);
                textBoxMrp.Text=Convert.ToString(_purchase.UnitPrice + ((25 * _purchase.UnitPrice) / 100));
                _purchase.MRP = Convert.ToDouble(textBoxMrp.Text);
                List<Purchase> purchasesCode = _purchaseManager.SearchPurchasesCode(_purchase);
                List<Purchase> purchasesBill = _purchaseManager.SearchSupplierBill(_purchase);
                if (purchasesBill.Count>0)
                {
                    MessageBox.Show("Bill-Invoice No. Exists!");
                }
                else if (purchasesCode.Count>0)
                {
                    MessageBox.Show("Purchase Code Exists!");
                    serialNo--;
                    textBoxCode.Text = serialNo.ToString();
                }
                else
                {
                    
                    bool isAdded = _purchaseManager.SavePurchase(_purchase);
                    if (isAdded)
                    {
                        MessageBox.Show("Submitted!");
                        dataGridViewPurchase.DataSource = _purchaseManager.SavePurchase(_purchase);
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
