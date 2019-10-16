using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Stock
    {
        public string Product { get; set; }
        public string Category { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        //public string Id { get; set; }
       // Code,Name,Category,ReOrderLevel
         public string Code { get; set; }
        public string Name { get; set; }
        //public string Category { get; set; }
        public string ReOrderLevel { get; set; }
    }
}
