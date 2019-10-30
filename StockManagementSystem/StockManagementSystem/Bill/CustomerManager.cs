using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;

namespace StockManagementSystem.Bill
{
    class CustomerManager
    {
        CustomerRepository _customerRepository=new CustomerRepository();

        public List<Customer> ShowCustomer(Customer _customer)
        {
            return _customerRepository.ShowCustomer(_customer);
        }

        public List<Customer> SearchCustomerName(Customer _customer)
        {
            return _customerRepository.SearchCustomerName(_customer);
        }

        public List<Customer> SearchCustomerCode(Customer _customer)
        {
            return _customerRepository.SearchCustomerCode(_customer);
        }

        public List<Customer> SearchCustomerContact(Customer _customer)
        {
            return _customerRepository.SearchCustomerContact(_customer);
        }

        public List<Customer> SearchCustomerEmail(Customer _customer)
        {
            return _customerRepository.SearchCustomerEmail(_customer);
        }

        public bool SaveCustomer(Customer _customer)
        {
            return _customerRepository.SaveCustomer(_customer);
        }

        public List<Customer> SearchCustomerContact2(Customer _customer)
        {
            return _customerRepository.SearchCustomerContact2(_customer);
        }

        public List<Customer> SearchCustomerEmail2(Customer _customer)
        {
            return _customerRepository.SearchCustomerEmail2(_customer);
        }

        public List<Customer> SearchCustomerName2(Customer _customer)
        {
            return _customerRepository.SearchCustomerName2(_customer);
        }
    }
}
