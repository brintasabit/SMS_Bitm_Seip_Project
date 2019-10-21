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

        public bool SavePurchase(Purchase _purchase)
        {
            return _purchaseRepository.SavePurchase(_purchase);
        }

        public List<Purchase> ShowPurchases(Purchase _purchase)
        {
            return _purchaseRepository.ShowPurchases(_purchase);
        }

        public List<Purchase> SearchPurchasesCode(Purchase _purchase)
        {
            return _purchaseRepository.SearchPurchasesCode(_purchase);
        }

        public List<Purchase> SearchPurchasesExpireDate(Purchase _purchase)
        {
            return _purchaseRepository.SearchPurchasesExpireDate(_purchase);
        }

        public List<Purchase> SearchPurchasesManufacturedDate(Purchase _purchase)
        {
            return _purchaseRepository.SearchPurchasesManufacturedDate(_purchase);
        }
    }
}
