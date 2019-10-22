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
    public partial class PartyModuleSupplier : Form
    {
        Supplier _supplier=new Supplier();
        SupplierManager _supplierManager=new SupplierManager();
        public PartyModuleSupplier()
        {
            InitializeComponent();
        }

        private void dataGridViewSupplier_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewSupplier.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void PartyModuleSupplier_Load(object sender, EventArgs e)
        {
            dataGridViewSupplier.DataSource = _supplierManager.ShowSupplier(_supplier);
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _supplier.Code = textBoxCode.Text;
                _supplier.Name = textBoxName.Text;
                _supplier.Address = textBoxAddress.Text;
                _supplier.Email = textBoxEmail.Text;
                _supplier.Contact = textBoxContact.Text;
                _supplier.ContactPerson = textBoxContactPerson.Text;
                List<Supplier> suppliersCode = _supplierManager.SearchSupplierCode(_supplier);
                List<Supplier> suppliersContact = _supplierManager.SearchSupplierContact(_supplier);
                List<Supplier> suppliersEmail = _supplierManager.SearchSupplierEmail(_supplier);
                if (_supplier.Code.Length==0)
                {
                    MessageBox.Show("Code can't be empty!");
                }
                else if (_supplier.Code.Length>4)
                {
                    MessageBox.Show("Code can't be greater than 4 character!");
                }
                else if (_supplier.Code.Length<4)
                {
                    MessageBox.Show("Code is 4 character long!");
                }
                else if (suppliersCode.Count > 0)
                {
                    MessageBox.Show("Code Exists!");
                }
                else if (_supplier.Name.Length==0)
                {
                    MessageBox.Show("Name can't be empty!");
                }
                else if (_supplier.Contact.Length==0)
                {
                    MessageBox.Show("Contact can't be empty!");
                }
                else if (suppliersContact.Count > 0)
                {
                    MessageBox.Show("Contact Exists!");
                }
                else if (_supplier.Email.Length==0)
                {
                    MessageBox.Show("Email can't be empty!");
                }
                else if (suppliersEmail.Count > 0)
                {
                    MessageBox.Show("Email Exists!");
                }
                else if (_supplier.Name.Length==0)
                {
                    MessageBox.Show("Name can't be empty!");
                }
                else
                {
                    bool isSaved = _supplierManager.SaveSupplier(_supplier);
                    if (isSaved)
                    {
                        MessageBox.Show("Saved!");
                        dataGridViewSupplier.DataSource = _supplierManager.SearchSupplierCode(_supplier);

                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void PartyModuleSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxCode.Text = dataGridViewSupplier.SelectedRows[0].Cells[1].Value.ToString();
                textBoxName.Text = dataGridViewSupplier.SelectedRows[0].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewSupplier.SelectedRows[0].Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridViewSupplier.SelectedRows[0].Cells[4].Value.ToString();
                textBoxContact.Text = dataGridViewSupplier.SelectedRows[0].Cells[5].Value.ToString();
                textBoxContactPerson.Text = dataGridViewSupplier.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridViewSupplier_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxCode.Text = dataGridViewSupplier.SelectedRows[0].Cells[1].Value.ToString();
                textBoxName.Text = dataGridViewSupplier.SelectedRows[0].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewSupplier.SelectedRows[0].Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridViewSupplier.SelectedRows[0].Cells[4].Value.ToString();
                textBoxContact.Text = dataGridViewSupplier.SelectedRows[0].Cells[5].Value.ToString();
                textBoxContactPerson.Text = dataGridViewSupplier.SelectedRows[0].Cells[6].Value.ToString();
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
                _supplier.Search = textBoxSearch.Text;
                List<Supplier> suppliersName = _supplierManager.SearchSupplierName2(_supplier);
                List<Supplier> suppliersContact = _supplierManager.SearchSupplierContact2(_supplier);
                List<Supplier> suppliersEmail = _supplierManager.SearchSupplierEmail2(_supplier);
                if (_supplier.Search.Length==0)
                {
                    MessageBox.Show("Enter Data!");
                    textBoxSearch.Clear();
                }
                else if (suppliersContact.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewSupplier.DataSource=_supplierManager.SearchSupplierContact2(_supplier);
                }
                else if (suppliersEmail.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewSupplier.DataSource=_supplierManager.SearchSupplierEmail2(_supplier);
                }
                else if (suppliersName.Count>0)
                {
                    MessageBox.Show("Data found!");
                    textBoxSearch.Clear();
                    dataGridViewSupplier.DataSource=_supplierManager.SearchSupplierName2(_supplier);
                }
                else
                {
                    textBoxSearch.Clear();
                    MessageBox.Show("Not found!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }
    }
}
