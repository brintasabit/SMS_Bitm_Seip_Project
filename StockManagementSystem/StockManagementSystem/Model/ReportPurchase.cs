using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class ReportPurchase
    {
        public  string StartDate { get; set; }
        public  string EndDate { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string AvailableQty { get; set; }
        public string CurrentPrice { get; set; }
        public string MRP { get; set; }
        public string Profit { get; set; }
    }
}
