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
    class CategoryRepository
    {
        Connection connection=new Connection();
        public List<Category> ShowCategories(Category _category)
        {
            List<Category> categories=new List<Category>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;

        }
        public List<Category> SearchCategoriesCode(Category _category)
        {
            List<Category> categories=new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Category where Code='"+_category.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;
        }
        public List<Category> SearchCategoriesName(Category _category)
        {
            List<Category> categories=new List<Category>();
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Category where Name='"+_category.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;
        }
        public bool SaveInfo(Category _category)
        {
            //string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into Category values('"+_category.Code+"','"+_category.Name+"')";
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
        public List<Category> SearchCategoriesCode2(Category _category)
        {
            List<Category> categories=new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Category where Code='"+_category.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;
        }
        public List<Category> SearchCategoriesName2(Category _category)
        {
            List<Category> categories=new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Category where Name='"+_category.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;
        }

        public bool UpdateCategories(Category _category)
        {
            List<Category>categories=new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"update Category set Code='"+_category.Code+"',Name='"+_category.Name+"' where Code='"+_category.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isUpdated=sqlCommand.ExecuteNonQuery();
            if (isUpdated>0)
            {
                return true;
            }
            //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //while (sqlDataReader.Read())
            //{
            //    Category category=new Category();
            //    category.Code = sqlDataReader["Code"].ToString();
            //    category.Name = sqlDataReader["Name"].ToString();
            //    categories.Add(category);
            //}
            sqlConnection.Close();
            return false;
        }
        public bool DeleteCategories(Category _category)
        {
            List<Category>categories=new List<Category>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"delete from Category where Code='"+_category.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isDeleted=sqlCommand.ExecuteNonQuery();
            if (isDeleted>0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }
    }
}
