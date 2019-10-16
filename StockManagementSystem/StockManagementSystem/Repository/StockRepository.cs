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
    class StockRepository
    {
        public List<Stock> ShowStock(Stock _stock)
        {
            List<Stock> stocks=new List<Stock>();
            string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"select Code,Name,Category,ReOrderLevel from Product where Name='"+_stock.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Stock stock=new Stock();
                stock.Code = sqlDataReader["Code"].ToString();
                stock.Name = sqlDataReader["Name"].ToString();
                stock.Category = sqlDataReader["Category"].ToString();
                stock.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();
            return stocks;

        }
        public List<Stock> SearchStockProduct(Stock _stock)
        {
            List<Stock> stocks=new List<Stock>();
            string connectionString = @"Server=BRINTA-PC; Database=StockManagementSystem; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"select Code,Name,Category,ReOrderLevel from Product where Name='"+_stock.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Stock stock=new Stock();
                stock.Code = sqlDataReader["Code"].ToString();
                stock.Name = sqlDataReader["Name"].ToString();
                stock.Category = sqlDataReader["Category"].ToString();
                stock.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();
            return stocks;
        }
    }
}
