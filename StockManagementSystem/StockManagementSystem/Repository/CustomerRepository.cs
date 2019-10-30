using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;

namespace StockManagementSystem.Repository
{
    class CustomerRepository
    {
        Connection connection=new Connection();
        public List<Customer> ShowCustomer(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;

        } 
        public List<Customer> SearchCustomerName(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Name='"+_customer.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public List<Customer> SearchCustomerCode(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Code='"+_customer.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public List<Customer> SearchCustomerContact(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Contact='"+_customer.Contact+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public List<Customer> SearchCustomerEmail(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Email='"+_customer.Email+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public bool SaveCustomer(Customer _customer)
        {
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into Customer values('"+_customer.Code+"','"+_customer.Name+"','"+_customer.Address+"','"+_customer.Email+"','"+_customer.Contact+"','"+_customer.LoyaltyPoint+"')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isSaved = sqlCommand.ExecuteNonQuery();
            if (isSaved>0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }
        public List<Customer> SearchCustomerName2(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Name='"+_customer.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public List<Customer> SearchCustomerContact2(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Contact='"+_customer.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }
        public List<Customer> SearchCustomerEmail2(Customer _customer)
        {
            List<Customer> customers=new List<Customer>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Customer where Email='"+_customer.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Customer customer=new Customer();
                customer.Code = sqlDataReader["Code"].ToString();
                customer.Name = sqlDataReader["Name"].ToString();
                customer.Address = sqlDataReader["Address"].ToString();
                customer.Email=sqlDataReader["Email"].ToString();
                customer.Contact=sqlDataReader["Contact"].ToString();
                customer.LoyaltyPoint=sqlDataReader["LoyaltyPoint"].ToString();
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }

    }
}
