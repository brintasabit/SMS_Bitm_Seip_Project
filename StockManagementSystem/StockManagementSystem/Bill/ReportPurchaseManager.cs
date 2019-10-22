using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;

namespace StockManagementSystem.Bill
{
    class ReportPurchaseManager
    {
        ReportPurchaseRepository _reportPurchaseRepository=new ReportPurchaseRepository();
        public List<ReportPurchase> SearchStockProductCategory(ReportPurchase _reportPurchase)
        {
            return _reportPurchaseRepository.SearchPurchaseDate(_reportPurchase);
        }

        public List<ReportPurchase> ShowReportPurchases(ReportPurchase _reportPurchase)
        {
            return _reportPurchaseRepository.ShowReportPurchases(_reportPurchase);
        }
    }
}
