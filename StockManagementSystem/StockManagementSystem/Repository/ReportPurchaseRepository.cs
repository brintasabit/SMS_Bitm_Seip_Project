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
    class ReportPurchaseRepository
    {
        Connection connection=new Connection();
        public List<ReportPurchase> SearchPurchaseDate(ReportPurchase _reportPurchase)
        {
            List<ReportPurchase> reportPurchases=new List<ReportPurchase>();
            
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Code,Products,Category,AvailableQty,UnitPrice as CurrentPrice,MRP,Profit from ProductsPurchase where Date between '"+_reportPurchase.StartDate+"' and '"+_reportPurchase.EndDate+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ReportPurchase reportPurchase=new ReportPurchase();
                //stock.Code = sqlDataReader["Code"].ToString();
                //stock.Name = sqlDataReader["Name"].ToString();
                //stock.Category = sqlDataReader["Category"].ToString();
                //stock.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                //stock.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                //stock.Quantity = sqlDataReader["Quantity"].ToString();
                reportPurchase.Code=sqlDataReader["Code"].ToString();
                reportPurchase.Name=sqlDataReader["Products"].ToString();
                reportPurchase.Category=sqlDataReader["Category"].ToString();
                reportPurchase.AvailableQty=sqlDataReader["AvailableQty"].ToString();
                reportPurchase.CurrentPrice=sqlDataReader["CurrentPrice"].ToString();
                reportPurchase.MRP=sqlDataReader["MRP"].ToString();
                reportPurchase.Profit=sqlDataReader["Profit"].ToString();
                reportPurchases.Add(reportPurchase);
            }
            sqlConnection.Close();
            return reportPurchases;
        }
        public List<ReportPurchase> ShowReportPurchases(ReportPurchase _reportPurchase)
        {
            List<ReportPurchase> reportPurchases = new List<ReportPurchase>();

            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Code,Products,Category,AvailableQty,UnitPrice as CurrentPrice,MRP,Profit from ProductsPurchase where Date between '" + _reportPurchase.StartDate + "' and '" + _reportPurchase.EndDate + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                ReportPurchase reportPurchase = new ReportPurchase();
                //stock.Code = sqlDataReader["Code"].ToString();
                //stock.Name = sqlDataReader["Name"].ToString();
                //stock.Category = sqlDataReader["Category"].ToString();
                //stock.ReOrderLevel = sqlDataReader["ReOrderLevel"].ToString();
                //stock.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                //stock.Quantity = sqlDataReader["Quantity"].ToString();
                reportPurchase.Code = sqlDataReader["Code"].ToString();
                reportPurchase.Name = sqlDataReader["Products"].ToString();
                reportPurchase.Category = sqlDataReader["Category"].ToString();
                reportPurchase.AvailableQty = sqlDataReader["AvailableQty"].ToString();
                reportPurchase.CurrentPrice = sqlDataReader["CurrentPrice"].ToString();
                reportPurchase.MRP = sqlDataReader["MRP"].ToString();
                reportPurchase.Profit = sqlDataReader["Profit"].ToString();
                reportPurchases.Add(reportPurchase);
            }
            sqlConnection.Close();
            return reportPurchases;
        }
    }
}
