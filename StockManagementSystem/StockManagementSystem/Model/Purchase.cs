using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Purchase
    {
        public string Category { get; set; }
        public string Products { get; set; }
        public string Code { get; set; }
        public string AvailableQuantity { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpiredDate { get; set; }
        public string Remarks { get; set; }
        public string UnitPrice { get; set; }
        public string TotalPrice { get; set; }
        public string PreviousUnitPrice { get; set; }
        public string PreviousMRP { get; set; }
        public string MRP { get; set; }
    }
}
