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
    public partial class ProductCatalogModuleCategory : Form
    {
        CategoryManager _categoryManager=new CategoryManager();
        Category _category=new Category();
        public ProductCatalogModuleCategory()
        {
            InitializeComponent();
        }

        private void dataGridViewCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
    }
}
