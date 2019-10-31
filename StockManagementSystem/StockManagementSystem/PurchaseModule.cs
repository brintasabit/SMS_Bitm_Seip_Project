using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //Connection connection=new Connection();
        PurchaseManager _purchaseManager=new PurchaseManager();
        Purchase _purchase=new Purchase();
        Product _product=new Product();
        //SuppliersPurchase _suppliersPurchase=new SuppliersPurchase();
        //DateTime aDateTime=DateTime.UtcNow;
        public PurchaseModule()
        {
            InitializeComponent();
        }
        private int serialNo = 2020;
        
        private void PurchaseModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet1.ProductsPurchase' table. You can move, or remove it, as needed.
           // this.productsPurchaseTableAdapter.Fill(this.stockManagementSystemDataSet1.ProductsPurchase);
           //_purchase.Category = comboBoxCategory.Text;
           comboBoxSupplier.DataSource = _purchaseManager.ComboBoxSupplierList();
           comboBoxCategory.DataSource = _purchaseManager.ComboBoxCategoryList();
           //comboBoxProducts.DataSource = _purchaseManager.ComboBoxProductList2(_product);
           dataGridViewPurchase.DataSource = _purchaseManager.ShowPurchases(_purchase);
          // textBoxAvailableQuantity.Text = 0.ToString();
           //textBoxPreviousUnitPrice.Text = 0.ToString();
           //textBoxPreviousMrp.Text = 0.ToString();
          // serialNo--;
           //textBoxCode.Text = serialNo.ToString();
           //textBoxDate.Text = aDateTime.ToString();
          // _product.Name = comboBoxProducts.Text;
           
           
        }

        private void dataGridViewPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPurchase.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _purchase.Date = dateTimePickerSupplier.Text;
                _purchase.BillInvoice = textBoxBillInvoice.Text;
                _purchase.SupplierName = comboBoxSupplier.Text;
                _purchase.Category = comboBoxCategory.Text;
                _purchase.Products = comboBoxProducts.Text;
                _purchase.Code = textBoxCode.Text;
                int availableQty = _purchaseManager.SearchProductAvailableQty(_purchase);
                if (availableQty >= 0)
                {
                    int availableQty2 = _purchase.Quantity + availableQty;
                    textBoxAvailableQuantity.Text = availableQty2.ToString();
                }
                
                _purchase.AvailableQuantity = Convert.ToInt32(textBoxAvailableQuantity.Text);
                _purchase.ManufacturedDate = dateTimePickerManufactured.Text;
                _purchase.ExpireDate = dateTimePickerExpire.Text;
                _purchase.Remarks = textBoxRemarks.Text;
                _purchase.Quantity = Convert.ToInt32(textBoxQuantity.Text);
                _purchase.UnitPrice = Convert.ToDouble(textBoxUnitPrice.Text);
                textBoxTotalPrice.Text=Convert.ToString(_purchase.Quantity * _purchase.UnitPrice);
                _purchase.TotalPrice = Convert.ToDouble(textBoxTotalPrice.Text);
                _purchase.PreviousUnitPrice = Convert.ToDouble(textBoxPreviousUnitPrice.Text);
                _purchase.PreviousMRP=Convert.ToDouble(textBoxPreviousMrp.Text);
                textBoxMrp.Text=Convert.ToString((_purchase.UnitPrice + ((25 * _purchase.UnitPrice) / 100)));
                _purchase.MRP = Convert.ToDouble(textBoxMrp.Text);
                _purchase.Profit = _purchase.MRP - _purchase.UnitPrice ;
                List<Purchase> purchasesCode = _purchaseManager.SearchPurchasesCode(_purchase);
                List<Purchase> purchasesBill = _purchaseManager.SearchSupplierBill(_purchase);
                //List<int> purchasesAvailableQty = _purchaseManager.SearchProductAvailableQty(_purchase);
                if (purchasesBill.Count>0)
                {
                    MessageBox.Show("Bill-Invoice No. Exists!");
                }
                //else if (purchasesCode.Count>0)
                //{
                //    MessageBox.Show("Purchase Code Exists!");
                //    serialNo--;
                //    textBoxCode.Text = serialNo.ToString();
                //}
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
                _purchase.Date = dateTimePickerSupplier.Text;
                _purchase.BillInvoice = textBoxBillInvoice.Text;
                _purchase.SupplierName = comboBoxSupplier.Text;
                _purchase.Category = comboBoxCategory.Text;
                _purchase.Products = comboBoxProducts.Text;
                _purchase.Code = textBoxCode.Text;
                //int availableQty = _purchaseManager.SearchProductAvailableQty(_purchase);
                //if (availableQty >= 0)
                //{
                //    int availableQty2 = _purchase.Quantity + availableQty;
                //    textBoxAvailableQuantity.Text = availableQty2.ToString();
                //}
                 _purchase.AvailableQuantity = Convert.ToInt32(textBoxAvailableQuantity.Text);
                _purchase.ManufacturedDate = dateTimePickerManufactured.Text;
                _purchase.ExpireDate = dateTimePickerExpire.Text;
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


                //else if (purchasesCode.Count>0)
                //{
                //    MessageBox.Show("Purchase Code Exists!");
                //    serialNo--;
                //    textBoxCode.Text = serialNo.ToString();
                //}
                else
                {
                    
                    bool isAdded = _purchaseManager.SavePurchase(_purchase);
                    if (isAdded)
                    {
                        MessageBox.Show("Submitted!");
                        dataGridViewPurchase.DataSource = _purchaseManager.ShowPurchases(_purchase);
                    }
                }
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                _purchase.Search = textBoxSearch.Text;
                List<Purchase> purchasesDate = _purchaseManager.SearchPurchasesDate(_purchase);
                List<Purchase> purchasesCode = _purchaseManager.SearchProductCode(_purchase);
                if (_purchase.Search.Length==0)
                {
                    MessageBox.Show("Enter data!");

                }
                else if (purchasesDate.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewPurchase.DataSource=_purchaseManager.SearchPurchasesDate(_purchase);
                }
                else if (purchasesCode.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewPurchase.DataSource=_purchaseManager.SearchProductCode(_purchase);
                }
                else
                {
                    MessageBox.Show("Not found!");
                    textBoxSearch.Clear();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            _product.Name = comboBoxProducts.Text;
            _purchase.Products = comboBoxProducts.Text;
            textBoxCode.Text = _purchaseManager.SearchProductCode2(_product);
            //int availableQty=_purchaseManager.SearchProductAvailableQty(_purchase);

            textBoxAvailableQuantity.Text =
                _purchaseManager.SearchProductAvailableQty(_purchase).ToString(); 
            textBoxPreviousUnitPrice.Text = _purchaseManager.SearchProductPreviousUnitPrice(_purchase).ToString();
            textBoxPreviousMrp.Text = _purchaseManager.SearchProductPreviousMRP(_purchase).ToString();
            //textBoxAvailableQuantity.Text=
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _product.Category = comboBoxCategory.Text;
            List<Product> products = _purchaseManager.ComboBoxProductList2(_product);
            if (products.Count>0)
            {
                comboBoxProducts.DataSource = _purchaseManager.ComboBoxProductList2(_product);
            }
        }

        //private void comboBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        //{ 
        //    //comboBoxProducts.Text=_product.Name;
        //    //_product.Name = comboBoxProducts.Text;
        //    //_purchase.Products = comboBoxProducts.Text;

        //    //textBoxCode.Text = Convert.ToString(_purchaseManager.SearchProductCode2(_product));
        //    bool r = _purchaseManager.SearchProduct(_purchase);
        //    if (r)
        //    {
        //        textBoxCode.Text = Convert.ToString(_purchaseManager.SearchProduct(_purchase));
        //    }

        //}
    }
}
