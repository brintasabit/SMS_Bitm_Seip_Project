using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem
{
    public partial class StockManagementSystemHome : Form
    {
        ProductCatalogModuleCategory pcmc=new ProductCatalogModuleCategory();
        ProductCatalogModuleProduct pcmp=new ProductCatalogModuleProduct();
        PartyModuleCustomer pmc=new PartyModuleCustomer();
        PartyModuleSupplier pms=new PartyModuleSupplier();
        PurchaseModule purchaseModule=new PurchaseModule();
        public StockManagementSystemHome()
        {
            InitializeComponent();
        }

        private void ButtonCategory_Click(object sender, EventArgs e)
        {
            if (pcmc.IsDisposed)
            {
                pcmc=new ProductCatalogModuleCategory();
            }
            pcmc.Show();
            pcmc.BringToFront();
        }

        private void ButtonProduct_Click(object sender, EventArgs e)
        {
            if (pcmp.IsDisposed)
            {
                pcmp=new ProductCatalogModuleProduct();
            }
            pcmp.Show();
            pcmp.BringToFront();
        }

        private void ButtonSupplier_Click(object sender, EventArgs e)
        {
            if (pms.IsDisposed)
            {
                pms=new PartyModuleSupplier();
            }
            pms.Show();
            pms.BringToFront();
        }

        private void ButtonCustomer_Click(object sender, EventArgs e)
        {
            if (pmc.IsDisposed)
            {
                pmc=new PartyModuleCustomer();
            }
            pmc.Show();
            pmc.BringToFront();
        }

        private void ButtonPurchaseModule_Click(object sender, EventArgs e)
        {
            if (purchaseModule.IsDisposed)
            {
                purchaseModule=new PurchaseModule();
            }
            purchaseModule.Show();
            purchaseModule.BringToFront();
        }
    }
}
