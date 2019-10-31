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
            return products;
        }
        public List<Product> ComboBoxProductList()
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
                //Purchase purchase=new Purchase();
                product.Name = sqlDataReader["Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public List<Product> ComboBoxProductList2(Product _product)
        {
            
            List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Name from Product where Category='"+_product.Category+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Product product=new Product();
                //Purchase purchase=new Purchase();
                product.Name = sqlDataReader["Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;
        }
        public List<Purchase> SearchSupplierBill(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase where Bill='"+_purchase.BillInvoice+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                purchase.BillInvoice = sqlDataReader["Bill"].ToString();
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        public List<Purchase> SearchProductCode(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase where Code='"+_purchase.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.Code=sqlDataReader["Code"].ToString();
                //purchase.Products=sqlDataReader["Products"].ToString();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //suppliersPurchase.BillInvoice = sqlDataReader["BillInvoice"].ToString();
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();

                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        //public bool AddSuppliersPurchase(SuppliersPurchase _suppliersPurchase)
        //{
        //    SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
        //    string commandString = @"insert into SuppliersPurchase values('"+_suppliersPurchase.Date+"','"+_suppliersPurchase.BillInvoice+"','"+_suppliersPurchase.SupplierName+"')";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
        //    sqlConnection.Open();
        //    int isSaved = sqlCommand.ExecuteNonQuery();
        //    if (isSaved>0)
        //    {
        //        return true;
        //    }
        //    sqlConnection.Close();
        //    return false;
        //}
        public bool SavePurchase(Purchase _purchase)
        {
            //_purchase.TotalPrice = _purchase.Quantity * _purchase.UnitPrice;
            //_purchase.MRP = _purchase.UnitPrice + ((25 * _purchase.UnitPrice) / 100);
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into ProductsPurchase 
                                     values ('"+_purchase.Date+"','"+_purchase.BillInvoice+"','"+_purchase.SupplierName+"','"+_purchase.Category+"','"+_purchase.Products+"','"+_purchase.Code+"',"+_purchase.AvailableQuantity+",'"+_purchase.ManufacturedDate+"','"+_purchase.ExpireDate+"','"+_purchase.Remarks+"',"+_purchase.Quantity+","+_purchase.UnitPrice+","+_purchase.TotalPrice+","+_purchase.UnitPrice+","+_purchase.MRP+","+_purchase.MRP+","+_purchase.Profit+")";
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
        public List<Purchase> ShowPurchases(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.Category = sqlDataReader["Category"].ToString();
                purchase.Products = sqlDataReader["Products"].ToString();
                purchase.Code = sqlDataReader["Code"].ToString();
                purchase.AvailableQuantity = Convert.ToInt32(sqlDataReader["AvailableQty"].ToString());
                purchase.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                purchase.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                purchase.Remarks = sqlDataReader["Remarks"].ToString();
                purchase.Quantity = Convert.ToInt32(sqlDataReader["Quantity"].ToString());
                purchase.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"].ToString());
                purchase.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"].ToString());
                purchase.PreviousUnitPrice = Convert.ToDouble(sqlDataReader["PreviousUnitPrice"].ToString());
                purchase.PreviousMRP = Convert.ToDouble(sqlDataReader["PreviousMRP"].ToString());
                purchase.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                purchase.Profit = Convert.ToDouble(sqlDataReader["Profit"].ToString());
                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;

        }
        public List<Purchase> SearchPurchasesCode(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase where Code='"+_purchase.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.Code = sqlDataReader["Code"].ToString();
                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        public List<Purchase> SearchPurchasesManufacturedDate(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase where ManufacturedDate='"+_purchase.ManufacturedDate+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        public List<Purchase> SearchPurchasesDate(Purchase _purchase)
        {
            List<Purchase> purchases=new List<Purchase>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from ProductsPurchase where ExpireDate='"+_purchase.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Purchase purchase=new Purchase();
                purchase.Category = sqlDataReader["Category"].ToString();
                purchase.Products = sqlDataReader["Products"].ToString();
                purchase.Code = sqlDataReader["Code"].ToString();
                purchase.AvailableQuantity = Convert.ToInt32(sqlDataReader["AvailableQty"].ToString());
                purchase.ManufacturedDate = sqlDataReader["ManufacturedDate"].ToString();
                purchase.ExpireDate = sqlDataReader["ExpireDate"].ToString();
                purchase.Remarks = sqlDataReader["Remarks"].ToString();
                purchase.Quantity = Convert.ToInt32(sqlDataReader["Quantity"].ToString());
                purchase.UnitPrice = Convert.ToDouble(sqlDataReader["UnitPrice"].ToString());
                purchase.TotalPrice = Convert.ToDouble(sqlDataReader["TotalPrice"].ToString());
                purchase.PreviousUnitPrice = Convert.ToDouble(sqlDataReader["PreviousUnitPrice"].ToString());
                purchase.PreviousMRP = Convert.ToDouble(sqlDataReader["PreviousMRP"].ToString());
                purchase.MRP = Convert.ToDouble(sqlDataReader["MRP"].ToString());
                purchase.Profit = Convert.ToDouble(sqlDataReader["Profit"].ToString());
                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
        public string SearchProductCode2(Product _product)
        {
           // List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Code from Product where Name='"+_product.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               // Product product=new Product();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //product.Name=sqlDataReader["Name"].ToString();
                _product.Code = sqlDataReader["Code"].ToString();
                
                
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
               // products.Add(product);
            }
            sqlConnection.Close();
            return _product.Code;
        }
        public bool SearchProduct(Purchase _purchase)
        {
            //_purchase.TotalPrice = _purchase.Quantity * _purchase.UnitPrice;
            //_purchase.MRP = _purchase.UnitPrice + ((25 * _purchase.UnitPrice) / 100);
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select Code from Product where Name='"+_purchase.Products+"'";
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
        public int SearchProductAvailableQty(Purchase _purchase)
        {
            // List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select AvailableQty from ProductsPurchase where Products='"+_purchase.Products+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                // Product product=new Product();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //product.Name=sqlDataReader["Name"].ToString();
                _purchase.AvailableQuantity = Convert.ToInt32(sqlDataReader["AvailableQty"].ToString());
                
                
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                // products.Add(product);
            }
            sqlConnection.Close();
            return _purchase.AvailableQuantity;
        }
        public double SearchProductPreviousUnitPrice(Purchase _purchase)
        {
            // List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select PreviousUnitPrice from ProductsPurchase where Products='"+_purchase.Products+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                // Product product=new Product();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //product.Name=sqlDataReader["Name"].ToString();
                _purchase.PreviousUnitPrice = Convert.ToDouble(sqlDataReader["PreviousUnitPrice"].ToString());
                
                
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                // products.Add(product);
            }
            sqlConnection.Close();
            return _purchase.PreviousUnitPrice;
        }
        public double SearchProductPreviousMRP(Purchase _purchase)
        {
            // List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select PreviousMRP from ProductsPurchase where Products='"+_purchase.Products+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                // Product product=new Product();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //product.Name=sqlDataReader["Name"].ToString();
                _purchase.PreviousMRP = Convert.ToDouble(sqlDataReader["PreviousMRP"].ToString());
                
                
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                // products.Add(product);
            }
            sqlConnection.Close();
            return _purchase.PreviousMRP;
        }
        public int SearchProductQty(Purchase _purchase)
        {
            // List<Product> products=new List<Product>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select AvailableQty from ProductsPurchase where Products='"+_purchase.Products+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                // Product product=new Product();
                //suppliersPurchase.Date = sqlDataReader["Date"].ToString();
                //product.Name=sqlDataReader["Name"].ToString();
                _purchase.AvailableQuantity = Convert.ToInt32(sqlDataReader["AvailableQty"].ToString());
                
                
                //suppliersPurchase.SupplierName = sqlDataReader["SupplierName"].ToString();
                // products.Add(product);
            }
            sqlConnection.Close();
            return _purchase.AvailableQuantity;
        }
    }
}
