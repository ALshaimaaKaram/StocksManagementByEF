using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Store
{
    public partial class ImportItem : Form
    {
        ItemImportServices ItemImportServices = new ItemImportServices();
        StockServices StockServices = new StockServices();
        CategoryServices CategoryServices = new CategoryServices();
        ItemServices ItemServices = new ItemServices();
        CategoriesInStockServices CategoriesInStockServices = new CategoriesInStockServices();
        //int CID;
        public ImportItem()
        {
            InitializeComponent();

            //Fill Stock Combox
            cmbStock.DisplayMember = "Name";
            cmbStock.ValueMember = "SID";
            cmbStock.DataSource = StockServices.GetStocks();

            dgvImportItem.DataSource = ItemImportServices.GetItemImports();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemImport ItemImport = new ItemImport();

            ItemImport.ItemID = (int)cmbItem.SelectedValue;
            ItemImport.QuantityIn = (int)numQuantity.Value;
            ItemImport.DateIn = DateTime.Now;

            ItemImportServices.AddItemImport(ItemImport);
            MessageBox.Show("Done");
            dgvImportItem.DataSource = ItemImportServices.GetItemImports();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Text = "";
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";
            cmbItem.DataSource = ItemServices.GetItemsByCSID((int)cmbCategory.SelectedValue);
        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategory.Text = "";
            cmbCategory.DisplayMember = "Category";
            cmbCategory.ValueMember = "ID";
            cmbCategory.DataSource = CategoriesInStockServices.GetCategoriesInStock((int)cmbStock.SelectedValue);
        }
    }
}