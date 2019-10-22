using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;
namespace StockManagementSystem.Bill
{
    class SalesManager
    {
        SalesRepository _salesRepository=new SalesRepository();
        public List<Sales> SearchSalesDate(Sales _sales)
        {
            return _salesRepository.SearchSalesDate(_sales);
        }
        public List<Sales> SearchSalesCustomer(Sales _sales)
        {
            return _salesRepository.SearchSalesCustomer(_sales);
        }
        public List<Sales> ShowSaleses(Sales _sales)
        {
            return _salesRepository.ShowSaleses(_sales);
        }
        public List<Product> ComboBoxCategoryList()
        {
            return _salesRepository.ComboBoxCategoryList();
        }

        public List<Product> ComboBoxProductsList()
        {
            return _salesRepository.ComboBoxProductsList();
        }

        public List<Sales> AvailableQty(Sales _sales)
        {
            return _salesRepository.AvailableQty(_sales);
        }

        public bool SaveSales(Sales _sales)
        {
            return _salesRepository.SaveSales(_sales);
        }
    }
}
