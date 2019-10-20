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
    }
}
