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
    public partial class ReportModulePurchase : Form
    {
        ReportPurchaseManager _reportPurchaseManager=new ReportPurchaseManager();
        ReportPurchase _reportPurchase=new ReportPurchase();
        public ReportModulePurchase()
        {
            InitializeComponent();
        }

        private void dataGridViewReportPurchase_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewReportPurchase.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _reportPurchase.StartDate = dateTimePickerStartDate.Text;
            _reportPurchase.EndDate = dateTimePickerEndDate.Text;
            try
            {
                _reportPurchase.StartDate = dateTimePickerStartDate.Text;
                _reportPurchase.EndDate = dateTimePickerEndDate.Text;
                List<ReportPurchase> reportPurchases = _reportPurchaseManager.SearchStockProductCategory(_reportPurchase);
                if (reportPurchases.Count>0)
                {
                    MessageBox.Show("Found!");
                    dataGridViewReportPurchase.DataSource =
                        _reportPurchaseManager.ShowReportPurchases(_reportPurchase);
                }
                else
                {
                    MessageBox.Show("Not Found!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
