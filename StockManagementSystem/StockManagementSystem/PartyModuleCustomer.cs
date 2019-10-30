using System;
using System.Collections.Generic;
using System.ComponentModel;
using StockManagementSystem.Model;
using StockManagementSystem.Bill;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class PartyModuleCustomer : Form
    {
        CustomerManager _customerManager=new CustomerManager();
        Customer _customer=new Customer();
        public PartyModuleCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCustomer.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _customer.Code = textBoxCode.Text;
                _customer.Name = textBoxName.Text;
                _customer.Contact = textBoxContact.Text;
                _customer.Email = textBoxEmail.Text;
                _customer.Address = textBoxAddress.Text;
                _customer.LoyaltyPoint = textBoxLoyaltyPoint.Text;
                List<Customer>customersCode=_customerManager.SearchCustomerCode(_customer);
                List<Customer> customersContact = _customerManager.SearchCustomerContact(_customer);
                List<Customer> customersEmail = _customerManager.SearchCustomerEmail(_customer);
                if (customersCode.Count>0)
                {
                    MessageBox.Show("Code Exists!");
                }
                else if (customersEmail.Count>0)
                {
                    MessageBox.Show("Email Exists!");
                }
                else if (customersContact.Count>0)
                {
                    MessageBox.Show("Contact Exists!");
                }
                else if (_customer.Code.Length>4)
                {
                    MessageBox.Show("Code must not greater than 4 character!");
                }
                else if (_customer.Code.Length<4)
                {
                    MessageBox.Show("Code must be 4 character!");
                }
                else if (_customer.Code.Length==0)
                {
                    MessageBox.Show("Code must be given!");
                }
                else if (_customer.Name.Length==0)
                {
                    MessageBox.Show("Name must be given!");
                }
                else if (_customer.Contact.Length==0)
                {
                    MessageBox.Show("Contact must be given!");
                }
                else if (_customer.Email.Length==0)
                {
                    MessageBox.Show("Email must be given!");
                }
                else
                {
                    bool isAdded = _customerManager.SaveCustomer(_customer);
                    if (isAdded)
                    {
                        MessageBox.Show("Saved Successfully!");
                        dataGridViewCustomer.DataSource = _customerManager.SearchCustomerCode(_customer);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

        }

        private void PartyModuleCustomer_Load(object sender, EventArgs e)
        {
            textBoxLoyaltyPoint.Text = 0.ToString();
            dataGridViewCustomer.DataSource = _customerManager.ShowCustomer(_customer);
        }

        private void PartyModuleCustomer_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void dataGridViewCustomer_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                textBoxCode.Text = dataGridViewCustomer.SelectedRows[0].Cells[1].Value.ToString();
                textBoxName.Text = dataGridViewCustomer.SelectedRows[0].Cells[2].Value.ToString();
                textBoxAddress.Text = dataGridViewCustomer.SelectedRows[0].Cells[3].Value.ToString();
                textBoxEmail.Text = dataGridViewCustomer.SelectedRows[0].Cells[4].Value.ToString();
                textBoxContact.Text = dataGridViewCustomer.SelectedRows[0].Cells[5].Value.ToString();
                textBoxLoyaltyPoint.Text = dataGridViewCustomer.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            _customer.Search = textBoxSearch.Text;
            List<Customer>customersName=_customerManager.SearchCustomerName2(_customer);
            List<Customer> customersContact = _customerManager.SearchCustomerContact2(_customer);
            List<Customer> customersEmail = _customerManager.SearchCustomerEmail2(_customer);
            if (_customer.Search.Length==0)
            {
                MessageBox.Show("Please Insert Something!");
            }
            else if (customersName.Count>0)
            {
                MessageBox.Show("Name found!");
                dataGridViewCustomer.DataSource = _customerManager.SearchCustomerName2(_customer);
            }
            else if (customersEmail.Count>0)
            {
                MessageBox.Show("Email found!");
                dataGridViewCustomer.DataSource = _customerManager.SearchCustomerEmail2(_customer);
            }
            else if (customersContact.Count>0)
            {
                MessageBox.Show("Contact found!");
                dataGridViewCustomer.DataSource = _customerManager.SearchCustomerContact2(_customer);
            }
            else
            {
                MessageBox.Show("Not found!");
            }
        }
    }
}
