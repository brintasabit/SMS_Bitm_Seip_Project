using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Purchase
    {
        public string Date { get; set; }
        public string BillInvoice { get; set; }
        public string SupplierName { get; set; }
        public string Category { get; set; }
        public string Products { get; set; }
        public string Code { get; set; }
        public int AvailableQuantity { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpireDate { get; set; }
        public string Remarks { get; set; }
        public int Quantity { get; set; }

        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double PreviousUnitPrice { get; set; }
        public double PreviousMRP { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }

    }
}
