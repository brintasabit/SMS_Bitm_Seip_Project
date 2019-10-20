using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;

namespace StockManagementSystem.Bill
{
    class SupplierManager
    {
        SupplierRepository _supplierRepository=new SupplierRepository();

        public List<Supplier> ShowSupplier(Supplier _supplier)
        {
            return _supplierRepository.ShowSupplier(_supplier);
        }

        public List<Supplier> SearchSupplierName(Supplier _supplier)
        {
            return _supplierRepository.SearchSupplierName(_supplier);
        }

        public List<Supplier> SearchSupplierContact(Supplier _supplier)
        {
            return _supplierRepository.SearchSupplierContact(_supplier);
        }

        public List<Supplier> SearchSupplierEmail(Supplier _supplier)
        {
            return _supplierRepository.SearchSupplierEmail(_supplier);
        }

        public List<Supplier> SearchSupplierCode(Supplier _supplier)
        {
            return _supplierRepository.SearchSupplierCode(_supplier);
        }

        public bool SaveSupplier(Supplier _supplier)
        {
            return _supplierRepository.SaveSupplier(_supplier);
        }
    }
}
