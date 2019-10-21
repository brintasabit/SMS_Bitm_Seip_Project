using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Model;
using StockManagementSystem.Repository;
namespace StockManagementSystem.Bill
{
    class StockManager
    {
        StockRepository _stockRepository=new StockRepository();
        public List<Stock> ShowStock(Stock _stock)
        {
            return _stockRepository.ShowStock(_stock);
        }

        public List<Stock> SearchStockProductName(Stock _stock)
        {
            return _stockRepository.SearchStockProductName(_stock);
        }

        public List<Stock> SearchStockProductCategory(Stock _stock)
        {
            return _stockRepository.SearchStockProductCategory(_stock);
        }
    }
}
