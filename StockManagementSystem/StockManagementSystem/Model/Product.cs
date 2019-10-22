using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Product
    {
        private string category;
        private string code;
        private string name;
        private string reOrderLevel;
        private string description;
        public string Search { get; set; }

        public string Category
        {
            get => category;
            set => category = value;
        }

        public string Code
        {
            get => code;
            set => code = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string ReOrderLevel
        {
            get => reOrderLevel;
            set => reOrderLevel = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }
    }
}
