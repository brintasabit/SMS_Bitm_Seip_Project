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

        public List<Product> ComboBoxProductList2(Product _product)
        {
            return _purchaseRepository.ComboBoxProductList2(_product);
        }
        public bool SearchProduct(Purchase _purchase)
        {
            return _purchaseRepository.SearchProduct(_purchase);
        }
        public List<Supplier> ComboBoxSupplierList()
        {
            return _purchaseRepository.ComboBoxSupplierList();
        }

        public List<Product> ComboBoxCategoryList()
        {
            return _purchaseRepository.ComboBoxCategoryList();
        }

        public List<Product> ComboBoxProductList()
        {
            return _purchaseRepository.ComboBoxProductList();
        }

        public List<Purchase> SearchSupplierBill(Purchase _purchase)
        {
            return _purchaseRepository.SearchSupplierBill(_purchase);
        }

        //public bool AddSuppliersPurchase(SuppliersPurchase _suppliersPurchase)
        //{
        //    return _purchaseRepository.AddSuppliersPurchase(_suppliersPurchase);
        //}

        public List<Purchase> SearchProductCode(Purchase _purchase)
        {
            return _purchaseRepository.SearchProductCode(_purchase);
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

        public List<Purchase> SearchPurchasesDate(Purchase _purchase)
        {
            return _purchaseRepository.SearchPurchasesDate(_purchase);
        }

        public List<Purchase> SearchPurchasesManufacturedDate(Purchase _purchase)
        {
            return _purchaseRepository.SearchPurchasesManufacturedDate(_purchase);
        }

        public string SearchProductCode2(Product _product)
        {
            return _purchaseRepository.SearchProductCode2(_product);
        }

        public int SearchProductAvailableQty(Purchase _purchase)
        {
            return _purchaseRepository.SearchProductAvailableQty(_purchase);
        }

        public double SearchProductPreviousUnitPrice(Purchase _purchase)
        {
            return _purchaseRepository.SearchProductPreviousUnitPrice(_purchase);
        }

        public double SearchProductPreviousMRP(Purchase _purchase)
        {
            return _purchaseRepository.SearchProductPreviousMRP(_purchase);
        }
    }
}
