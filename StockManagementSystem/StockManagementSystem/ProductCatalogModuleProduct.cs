using System;
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
    public partial class ProductCatalogModuleProduct : Form
    {
        ProductManager _productManager=new ProductManager();
        Product _product=new Product();
        public ProductCatalogModuleProduct()
        {
            InitializeComponent();
        }

        private void dataGridViewProduct_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewProduct.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ProductCatalogModuleProduct_Load(object sender, EventArgs e)
        {
            comboBoxCategory.DataSource = _productManager.ComboBoxCategoryList();
            dataGridViewProduct.DataSource = _productManager.ShowProduct(_product);
        }

        private void dataGridViewProduct_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                comboBoxCategory.Text=dataGridViewProduct.SelectedRows[0].Cells[1].Value.ToString();
                textBoxCode.Text = dataGridViewProduct.SelectedRows[0].Cells[2].Value.ToString();
                textBoxName.Text= dataGridViewProduct.SelectedRows[0].Cells[3].Value.ToString();
                textBoxReOrderLevel.Text=dataGridViewProduct.SelectedRows[0].Cells[4].Value.ToString();
                textBoxDescription.Text=dataGridViewProduct.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (buttonSave.Text=="Save")
                {
                    _product.Category = comboBoxCategory.Text;
                    _product.Code = textBoxCode.Text;
                    _product.Name = textBoxName.Text;
                    _product.ReOrderLevel = textBoxReOrderLevel.Text;
                    _product.Description = textBoxDescription.Text;
                    List<Product> productCode = _productManager.SearchProductCode(_product);
                    List<Product> productName = _productManager.SearchProductName(_product);
                    if (_product.Code.Length==0 && _product.Name.Length==0)
                    {
                        buttonSave.Text = "Update";
                    }
                    else if (_product.Category.Length==0)
                    {
                        MessageBox.Show("Select A Category");
                    }
                    else if (_product.Code.Length==0)
                    {
                        MessageBox.Show("Code can't be empty");
                        buttonSave.Text = "Update";
                    }
                    else if (_product.Code.Length<4)
                    {
                        MessageBox.Show("Code Must Be 4 Character");
                        //buttonSave.Text = "Update";
                    }
                    else if (_product.Code.Length>4)
                    {
                        MessageBox.Show("Code Must Not Exceed 4 Character!");
                    }
                    else if (productCode.Count>0)
                    {
                        MessageBox.Show("Code Exists!");
                    }
                    else if (_product.Name.Length==0)
                    {
                        MessageBox.Show("Name can't be empty'");
                    }
                    else if (productName.Count>0)
                    {
                        MessageBox.Show("Name Exists!");
                    }
                    else if (_product.ReOrderLevel.Length==0)
                    {
                        MessageBox.Show("Re-order level must be given");
                    }
                    else if (_product.ReOrderLevel.Length<0)
                    {
                        MessageBox.Show("Re-order level must be positive");
                    }
                    else
                    {
                        bool isSaved = _productManager.SaveProduct(_product);
                        if (isSaved)
                        {
                            
                            MessageBox.Show("Saved!");
                            buttonSave.Text = "Update";
                            dataGridViewProduct.DataSource = _productManager.SearchProductCode(_product);

                            textBoxCode.Clear();
                            textBoxDescription.Clear();
                            textBoxName.Clear();
                            textBoxReOrderLevel.Clear();
                            //comboBoxCategory.Text = "";
                        }
                    }
                }
                else if (buttonSave.Text=="Update")
                {
                    _product.Category = comboBoxCategory.Text;
                    _product.Code = textBoxCode.Text;
                    _product.Name = textBoxName.Text;
                    _product.ReOrderLevel = textBoxReOrderLevel.Text;
                    _product.Description = textBoxDescription.Text;
                    List<Product> productCode = _productManager.SearchProductCode(_product);
                    List<Product> productName = _productManager.SearchProductName(_product);
                    
                    if (_product.Code.Length==0 && _product.Name.Length==0)
                    {
                        buttonSave.Text = "Delete";
                    }
                    else if (_product.Category.Length==0)
                    {
                        MessageBox.Show("Select A Category");
                    }
                    else if (_product.Code.Length<4)
                    {
                        MessageBox.Show("Code Must Be 4 Character");
                    }
                    else if (_product.Code.Length>4)
                    {
                        MessageBox.Show("Code Must Not Exceed 4 Character!");
                    }
                    else if (productName.Count>0)
                    {
                        MessageBox.Show("Name Exists!");
                    }
                    else if (_product.ReOrderLevel.Length==0)
                    {
                        MessageBox.Show("Re-order level must be given");
                    }
                    else if (_product.ReOrderLevel.Length<0)
                    {
                        MessageBox.Show("Re-order level must be positive");
                    }
                    else
                    {
                        bool isSaved = _productManager.UpdateProduct(_product);
                        if (isSaved)
                        {
                            buttonSave.Text = "Delete";
                            MessageBox.Show("Updated!");
                            textBoxCode.Clear();
                            textBoxDescription.Clear();
                            textBoxName.Clear();
                            textBoxReOrderLevel.Clear();
                            dataGridViewProduct.DataSource = _productManager.SearchProductCode(_product);
                        }
                    }
                }
                else if (buttonSave.Text=="Delete")
                {

                    //comboBoxCategory.Text = "";
                    //_product.Category = comboBoxCategory.Text;
                    _product.Code = textBoxCode.Text;
                    _product.Name = textBoxName.Text;
                    //_product.ReOrderLevel = textBoxReOrderLevel.Text;
                    //_product.Description = textBoxDescription.Text;
                    List<Product> productCode = _productManager.SearchProductCode(_product);
                    List<Product> productName = _productManager.SearchProductName(_product);
                    if (_product.Code.Length==0 && _product.Name.Length==0)
                    {
                        buttonSave.Text = "Save";
                    }
                    else if (productCode.Count>0)
                    {
                        bool isSaved = _productManager.DeleteProduct(_product);
                        if (isSaved)
                        {
                            buttonSave.Text = "Delete";
                            MessageBox.Show("Deleted!");
                            textBoxCode.Clear();
                            textBoxDescription.Clear();
                            textBoxName.Clear();
                            textBoxReOrderLevel.Clear();
                            comboBoxCategory.Text = "";
                            dataGridViewProduct.DataSource = _productManager.ShowProduct(_product);
                        }
                        else
                        {
                            MessageBox.Show("Not Deleted!");
                        }
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
                _product.Search = textBoxSearch.Text;
                List<Product> productCode = _productManager.SearchProductCode2(_product);
                List<Product> productName = _productManager.SearchProductName2(_product);
                List<Product> productCategory = _productManager.SearchProductCatagory(_product);
                if (_product.Search.Length==0)
                {
                    MessageBox.Show("Enter Data!");
                    textBoxSearch.Clear();
                }
                else if (productCode.Count>0)
                {
                    MessageBox.Show("Found Code!");
                    dataGridViewProduct.DataSource=_productManager.SearchProductCode2(_product);
                    textBoxSearch.Clear();
                }
                else if (productName.Count>0)
                {
                    MessageBox.Show("Found Name!");
                    dataGridViewProduct.DataSource=_productManager.SearchProductName2(_product);
                    textBoxSearch.Clear();
                }
                else if (productCategory.Count>0)
                {
                    MessageBox.Show("Found Category!");
                    dataGridViewProduct.DataSource=_productManager.SearchProductCatagory(_product);
                    textBoxSearch.Clear();
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
