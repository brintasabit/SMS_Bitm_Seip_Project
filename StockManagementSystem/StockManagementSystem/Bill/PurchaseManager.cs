using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockManagementSystem.Repository;
using StockManagementSystem.Model;

namespace StockManagementSystem.Bill
{
    class PurchaseManager
    {
        PurchaseRepository _purchaseRepository=new PurchaseRepository();

        public List<Supplier> ComboBoxSupplierList()
        {
            return _purchaseRepository.ComboBoxSupplierList();
        }

        public List<Product> ComboBoxCategoryList()
        {
            return _purchaseRepository.ComboBoxCategoryList();
        }

        public List<Product> ComboBoxProductList(Product _product)
        {
            return _purchaseRepository.ComboBoxProductList(_product);
        }

        public List<SuppliersPurchase> SearchSupplierBill(SuppliersPurchase _suppliersPurchase)
        {
            return _purchaseRepository.SearchSupplierBill(_suppliersPurchase);
        }

        public bool AddSuppliersPurchase(SuppliersPurchase _suppliersPurchase)
        {
            return _purchaseRepository.AddSuppliersPurchase(_suppliersPurchase);
        }

        public List<Purchase> SearchProductCode(Product _product)
        {
            return _purchaseRepository.SearchProductCode(_product);
        }
    }
}
