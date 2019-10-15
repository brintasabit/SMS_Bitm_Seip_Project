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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                categoryBindingSource.EndEdit();
                categoryTableAdapter.Update(this.appdata.Category);
                _category.Code = textBoxCode.Text;
                _category.Name = textBoxName.Text;
                List<Category> categoriesCode = _categoryManager.SearchCategoriesCode(_category);
                List<Category> categoriesName = _categoryManager.SearchCategoriesName(_category);
                if (_category.Code.Length==0)
                {
                    MessageBox.Show("Code Can't Be Empty!");
                }
                else if(_category.Name.Length==0)
                {
                    MessageBox.Show("Name Can't Be Empty!");
                }
                else if (_category.Code.Length<4)
                {
                    MessageBox.Show("Code Must Be 4 Character");
                }
                else if (_category.Code.Length>4)
                {
                    MessageBox.Show("Code Must Not Exceed 4 Character!");
                }
                else if (categoriesCode.Count>0)
                {
                    MessageBox.Show("Code Exists!");
                }
                else if (categoriesName.Count>0)
                {
                    MessageBox.Show("Name Exists!");
                }
                else
                {
                    bool isSaved = _categoryManager.SaveInfo(_category);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved");
                        dataGridViewCategory.DataSource = _categoryManager.ShowCategories(_category);
                    }
                }
                textBoxCode.Clear();
                textBoxName.Clear();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            Cursor.Current = Cursors.Default;
        }

        private void dataGridViewCategory_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxCode.Text = dataGridViewCategory.SelectedRows[0].Cells[1].Value.ToString();
                textBoxName.Text= dataGridViewCategory.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ProductCatalogModuleCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appdata.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.appdata.Category);
            // TODO: This line of code loads data into the 'stockManagementSystemDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.appdata.Category);
            dataGridViewCategory.DataSource = _categoryManager.ShowCategories(_category);
        }

        private void dataGridViewCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete)
            {
                categoryBindingSource.RemoveCurrent();
            }
        }
    }
}
