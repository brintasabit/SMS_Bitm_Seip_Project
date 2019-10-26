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
    public partial class SalesModule : Form
    {
        SalesManager _salesManager=new SalesManager();
        Sales _sales=new Sales();
        public SalesModule()
        {
            InitializeComponent();
        }

        private void SalesModule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet2.Sales' table. You can move, or remove it, as needed.
           // this.salesTableAdapter.Fill(this.stockManagementSystemDataSet2.Sales);
           //_sales.Category = comboBoxCategory.Text;
           
           comboBoxCategory.DataSource = _salesManager.ComboBoxCategoryList();
           comboBoxProduct.DataSource = _salesManager.ComboBoxProductsList();
           dataGridViewSales.DataSource = _salesManager.ShowSaleses(_sales);

        }

        private void dataGridViewSales_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSales.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //int aviableQty = Convert.ToInt32(_salesManager.AvailableQty(_sales));
            //textBoxAvailableQuantity.Text = Convert.ToString(aviableQty);
            try
            {
                _sales.CustomerName = comboBoxCustomer.Text;
                _sales.Date = dateTimePickerCustomer.Text;
                _sales.LoyalityPoint = textBoxLoyalityPoint.Text;
                _sales.Category = comboBoxCategory.Text;
                _sales.Product = comboBoxProduct.Text;
                _sales.AvailableQty = textBoxAvailableQuantity.Text;
                _sales.Quantity = textBoxQuantity.Text;
                _sales.MRP = textBoxMRP.Text;
                _sales.TotalMRP = textBoxTotalMrp.Text;
                //bool isSaved = _salesManager.SaveSales(_sales);

                MessageBox.Show("Added!");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                _sales.CustomerName = comboBoxCustomer.Text;
                _sales.Date = dateTimePickerCustomer.Text;
                _sales.LoyalityPoint = textBoxLoyalityPoint.Text;
                _sales.Category = comboBoxCategory.Text;
                _sales.Product = comboBoxProduct.Text;
                _sales.AvailableQty = textBoxAvailableQuantity.Text;
                _sales.Quantity = textBoxQuantity.Text;
                _sales.MRP = textBoxMRP.Text;
                _sales.TotalMRP = textBoxTotalMrp.Text;
                bool isSaved = _salesManager.SaveSales(_sales);
                if (isSaved)
                {
                    MessageBox.Show("Submitted!");
                }
                else
                {
                    MessageBox.Show("failed!");
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
                _sales.Search = textBoxSearch.Text;
                List<Sales> salesesCustomer = _salesManager.SearchSalesCustomer(_sales);
                List<Sales> salesesDate = _salesManager.SearchSalesDate(_sales);
                if (_sales.Search.Length==0)
                {
                    MessageBox.Show("Enter Something!");
                }
                else if (salesesDate.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewSales.DataSource=_salesManager.SearchSalesDate(_sales);
                }
                else if (salesesCustomer.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewSales.DataSource=_salesManager.SearchSalesCustomer(_sales);
                }
                else
                {
                    MessageBox.Show("No Data!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
