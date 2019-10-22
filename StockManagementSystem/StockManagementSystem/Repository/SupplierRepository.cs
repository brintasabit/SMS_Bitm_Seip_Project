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
    class SupplierRepository
    {
        Connection connection=new Connection();
        public List<Supplier> ShowSupplier(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;

        } 
        public List<Supplier> SearchSupplierName(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Name='"+_supplier.Name+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        
        public List<Supplier> SearchSupplierContact(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Contact='"+_supplier.Contact+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        public List<Supplier> SearchSupplierContact2(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Contact='"+_supplier.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        public List<Supplier> SearchSupplierEmail(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Email='"+_supplier.Email+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        public List<Supplier> SearchSupplierEmail2(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Email='"+_supplier.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        public List<Supplier> SearchSupplierCode(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Code='"+_supplier.Code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
        public bool SaveSupplier(Supplier _supplier)
        {
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"insert into Supplier values('"+_supplier.Code+"','"+_supplier.Name+"','"+_supplier.Address+"','"+_supplier.Email+"','"+_supplier.Contact+"','"+_supplier.ContactPerson+"')";
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
        public List<Supplier> SearchSupplierName2(Supplier _supplier)
        {
            List<Supplier> suppliers=new List<Supplier>();
            SqlConnection sqlConnection = new SqlConnection(connection.connectionString);
            string commandString = @"select * from Supplier where Name='"+_supplier.Search+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Supplier supplier=new Supplier();
                supplier.Code = sqlDataReader["Code"].ToString();
                supplier.Name = sqlDataReader["Name"].ToString();
                supplier.Address = sqlDataReader["Address"].ToString();
                supplier.Email=sqlDataReader["Email"].ToString();
                supplier.Contact=sqlDataReader["Contact"].ToString();
                supplier.ContactPerson=sqlDataReader["ContactPerson"].ToString();
                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }
    }
}
