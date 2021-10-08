using BLL;
using DAL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class ExportItem : Form
    {
        ItemImportServices ItemImportServices = new ItemImportServices();
        ItemExportServices ItemExportServices = new ItemExportServices();
        StockServices StockServices = new StockServices();
        CategoryServices CategoryServices = new CategoryServices();
        ItemServices ItemServices = new ItemServices();
        CategoriesInStockServices CategoriesInStockServices = new CategoriesInStockServices();

        public ExportItem()
        {
            InitializeComponent();
            //Fill Stock Combox
            cmbStock.DisplayMember = "Name";
            cmbStock.ValueMember = "SID";
            cmbStock.DataSource = StockServices.GetStocks();

            dgvImportItem.DataSource = ItemExportServices.GetItemsExport();

            //Quantity
            

        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ID";
            cmbCategory.DataSource = CategoriesInStockServices.GetCategoriesInStock((int)cmbStock.SelectedValue);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Text = "";
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";
            cmbItem.DataSource = ItemServices.GetItemsByCSID((int)cmbCategory.SelectedValue);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ItemExport ItemExport = new ItemExport();

            ItemExport.ItemID = (int)cmbItem.SelectedValue;
            ItemExport.QuantityOut = (int)numQuantity.Value;
            ItemExport.DateOut = DateTime.Now;

            ItemExportServices.AddItemExport(ItemExport);
            MessageBox.Show("Done");
            dgvImportItem.DataSource = ItemExportServices.GetItemsExport();
            
        }
    }
}
