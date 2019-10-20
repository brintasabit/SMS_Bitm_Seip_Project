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
    class PurchaseRepository
    {
        Connection connection=new Connection();
        public List<Supplier> ComboBoxSupplierList()
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Name = sqlDataReader["Name"].ToString();
                suppliers.Add(supplier);
            }
            return suppliers;
        }
        public List<Product> ComboBoxCategoryList()
        {
            List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Category from Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Category = sqlDataReader["Category"].ToString();
                products.Add(product);
            }
            return products;
        }
        public List<Product> ComboBoxProductList(Product _product)
        {
            
            List<Product> purchases=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                //Purchase purchase=new Purchase();
                product.Name = sqlDataReader["Name"].ToString();
                purchases.Add(product);
            }
            return purchases;
        }
        public List<SuppliersPurchase> SearchSupplierBill(SuppliersPurchase _suppliersPurchase)
        {
            List<SuppliersPurchase> suppliersPurchases=new List<SuppliersPurchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from SuppliersPurchase where Bill='"+_suppliersPurchase.BillInvoice+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SuppliersPurchase suppliersPurchase=new SuppliersPurchase();
                suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                suppliersPurchase.BillInvoice = sqlDataReader["BillInvoice"].ToString();
                suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                suppliersPurchases.Add(suppliersPurchase);
            }
            sqlConnection.Close();
            return suppliersPurchases;
        }
        public List<Purchase> SearchProductCode(Product _product)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Code from Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.Code=sqlDataReader["Code"].ToString();
                purchase.Products=sqlDataReader["Products"].ToString();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //suppliersPurchase.BillInvoice = sqlDataReader["BillInvoice"].ToString();
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();

                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        public bool AddSuppliersPurchase(SuppliersPurchase _suppliersPurchase)
        {
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into SuppliersPurchase values('"+_suppliersPurchase.Date+"','"+_suppliersPurchase.BillInvoice+"','"+_suppliersPurchase.SupplierName+"')";
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
    }
}
