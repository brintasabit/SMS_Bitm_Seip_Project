using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Model
{
    class Customer
    {
        private string code;
        private string name;
        private string address;
        private string email;
        private string contact;
        private string loyaltyPoint;
        private int id;
        private string search;

        public string Search
        {
            get => search;
            set => search = value;
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

        public string Address
        {
            get => address;
            set => address = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Contact
        {
            get => contact;
            set => contact = value;
        }

        public string LoyaltyPoint
        {
            get => loyaltyPoint;
            set => loyaltyPoint = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }
    }
}
