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
    class ProductRepository
    {
        Connection connection=new Connection();
        public List<Product> ShowProduct(Product _product)
        {
            List<Product> products=new List<Product>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Category = sqlDataReader["Category"].ToString();
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                product.Description = sqlDataReader["Description"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public List<Category> ComboBoxCategoryList()
        {
            List<Category> categories=new List<Category>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            return categories;
        }
        public List<Product> SearchProductCode(Product _product)
        {
            List<Product> products=new List<Product>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Product where Code='"+_product.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Category = sqlDataReader["Category"].ToString();
                product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                product.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                product.Description = sqlDataReader["Description"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public List<Product> SearchProductName(Product _product)
        {
            List<Product> products=new List<Product>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Product where Name='"+_product.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                //product.Category = sqlDataReader["Category"].ToString();
                //product.Code = sqlDataReader["Code"].ToString();
                product.Name = sqlDataReader["Name"].ToString();
                //product.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                //product.Description = sqlDataReader["Description"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public bool SaveProduct(Product _product)
        {
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into Product values('"+_product.Category+"','"+_product.Code+"','"+_product.Name+"','"+_product.ReOrderLevel+"','"+_product.Description+" is fine')";
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
        public List<Product> SearchProductCatagory(Product _product)
        {
            List<Product> products=new List<Product>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Product where Category='"+_product.Category+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                product.Category = sqlDataReader["Category"].ToString();
                //product.Code = sqlDataReader["Code"].ToString();
                //product.Name = sqlDataReader["Name"].ToString();
                //product.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                //product.Description = sqlDataReader["Description"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
    }
}
