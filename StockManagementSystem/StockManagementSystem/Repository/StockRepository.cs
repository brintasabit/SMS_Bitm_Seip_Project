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
        Connection connection=new Connection();
        public List<Stock> ShowStock(Stock _stock)
        {
            List<Stock> stocks=new List<Stock>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Product as p left join ProductsPurchase as pp on pp.Products=p.Name";
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
                stock.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                stock.Quantity = sqlDataReader["Quantity"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();
            return stocks;

        }
        public List<Stock> SearchStockProductName(Stock _stock)
        {
            List<Stock> stocks=new List<Stock>();
            
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select p.Code,p.Name,pp.Category,ReOrderLevel,ExpireDate,Quantity 
                                     from Product as p left join ProductsPurchase as pp on pp.Products=p.Name where Name='"+_stock.Name+"'";
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
                stock.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                stock.Quantity = sqlDataReader["Quantity"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();
            return stocks;
        }
        public List<Stock> SearchStockProductCategory(Stock _stock)
        {
            List<Stock> stocks=new List<Stock>();
            
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select p.Code,p.Name,pp.Category,ReOrderLevel,ExpireDate,Quantity 
                                     from Product as p left join ProductsPurchase as pp on pp.Products=p.Name where pp.Category='"+_stock.Category+"'";
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
                stock.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                stock.Quantity = sqlDataReader["Quantity"].ToString();

                stocks.Add(stock);
            }
            sqlConnection.Close();
            return stocks;
        }
    }
}
