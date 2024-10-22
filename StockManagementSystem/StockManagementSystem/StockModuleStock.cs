﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockManagementSystem.Model;
using StockManagementSystem.Bill;
namespace StockManagementSystem
{
    public partial class StockModuleStock : Form
    {
        StockManager _stockManager=new StockManager();
        Stock _stock=new Stock();
        public StockModuleStock()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            _stock.Name = textBoxProduct.Text;
            _stock.Category = textBoxCategory.Text;
            //_stock.StartDate = textBoxStartDate.Text;
           // _stock.EndDate = textBoxEndDate.Text;
           List<Stock> stockProductName = _stockManager.SearchStockProductName(_stock);
           List<Stock> stockProductCategory = _stockManager.SearchStockProductCategory(_stock);

            if (stockProductName.Count>0)
            {
                MessageBox.Show("Found!");
                dataGridViewStock.DataSource = _stockManager.SearchStockProductName(_stock);
            }
            else if (stockProductCategory.Count>0)
            {
                MessageBox.Show("Found!");
                dataGridViewStock.DataSource = _stockManager.SearchStockProductCategory(_stock);
            }
            else
            {
                MessageBox.Show("Not Found!");
            }
        }

        private void dataGridViewStock_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewStock.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void StockModuleStock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet3.ProductsPurchase' table. You can move, or remove it, as needed.
            //this.productsPurchaseTableAdapter.Fill(this.stockManagementSystemDataSet3.ProductsPurchase);
            dataGridViewStock.DataSource = _stockManager.ShowStock(_stock);
        }
    }
}
