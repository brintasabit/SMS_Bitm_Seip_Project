using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using System.Data;
using System.Data.SqlClient;
namespace StockManagementSystem.Repository
{
    class SalesRepository
    {
        Connection connection=new Connection();
        public List<Product> ComboBoxCategoryList()
        {
            List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Category = sqlDataReader["Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public List<Product> ComboBoxProductsList()
        {
            List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Name = sqlDataReader["Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }

        public List<Sales> AvailableQty(Sales _sales)
        {
            List<Sales>saleses=new List<Sales>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Quantity from ProductsPurchase where Products='"+_sales.Product+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Sales sales=new Sales();
                sales.AvailableQty = sqlDataReader["Quantity"].ToString();
                saleses.Add(sales);
            }
            sqlConnection.Close();
            return saleses;
        }
        public bool SaveSales(Sales _sales)
        {
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into sales 
                                     values('"+_sales.CustomerName+"','"+_sales.Date+"','"+_sales.LoyalityPoint+"','"+_sales.Category+"','"+_sales.Product+"',"+_sales.AvailableQty+","+_sales.Quantity+","+_sales.MRP+","+_sales.TotalMRP+")";
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
        public List<Sales> ShowPurchases(Sales _sales)
        {
            List<Sales>saleses=new List<Sales>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Sales";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Sales sales=new Sales();
                sales.CustomerName = sqlDataReader["Customer"].ToString();
                sales.Date = sqlDataReader["Date"].ToString();
                sales.LoyalityPoint = sqlDataReader["LoyalityPoint"].ToString();
                sales.Category = sqlDataReader["Category"].ToString();
                sales.Product = sqlDataReader["Product"].ToString();
                sales.AvailableQty = sqlDataReader["AvailableQty"].ToString();
                sales.Quantity = sqlDataReader["Quantity"].ToString();
                sales.MRP = sqlDataReader["MRP"].ToString();
                sales.TotalMRP = sqlDataReader["TotalMRP"].ToString();
                saleses.Add(sales);
            }
            sqlConnection.Close();
            return saleses;

        }
        public List<Sales> SearchSalesDate(Sales _sales)
        {
            List<Sales>saleses=new List<Sales>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Sales where Date='"+_sales.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Sales sales=new Sales();
                sales.CustomerName = sqlDataReader["CustomerName"].ToString();
                sales.Date = sqlDataReader["Date"].ToString();
                sales.LoyalityPoint = sqlDataReader["LoyalityPoint"].ToString();
                sales.Category = sqlDataReader["Category"].ToString();
                sales.Product = sqlDataReader["Product"].ToString();
                sales.AvailableQty = sqlDataReader["AvailableQty"].ToString();
                sales.Quantity = sqlDataReader["Quantity"].ToString();
                sales.MRP = sqlDataReader["MRP"].ToString();
                sales.TotalMRP = sqlDataReader["TotalMRP"].ToString();
                saleses.Add(sales);
            }
            sqlConnection.Close();
            return saleses;
        }
        public List<Sales> SearchSalesCustomer(Sales _sales)
        {
            List<Sales>saleses=new List<Sales>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Sales where CustomerName='"+_sales.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Sales sales=new Sales();
                sales.CustomerName = sqlDataReader["CustomerName"].ToString();
                sales.Date = sqlDataReader["Date"].ToString();
                sales.LoyalityPoint = sqlDataReader["LoyalityPoint"].ToString();
                sales.Category = sqlDataReader["Category"].ToString();
                sales.Product = sqlDataReader["Product"].ToString();
                sales.AvailableQty = sqlDataReader["AvailableQty"].ToString();
                sales.Quantity = sqlDataReader["Quantity"].ToString();
                sales.MRP = sqlDataReader["MRP"].ToString();
                sales.TotalMRP = sqlDataReader["TotalMRP"].ToString();
                saleses.Add(sales);
            }
            sqlConnection.Close();
            return saleses;
        }
    }
}
