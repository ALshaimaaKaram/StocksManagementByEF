using BLL;
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
    public partial class Admin : Form
    {
        StockServices StockServices = new StockServices();
        CategoryServices CategoryServices = new CategoryServices();
        ItemServices ItemServices = new ItemServices();
        CategoriesInStockServices CategoriesInStockServices = new CategoriesInStockServices();
        public Admin()
        {
            InitializeComponent();
            //Tab of Stock
            dtgridStock.DataSource = StockServices.GetStocks();

            //Tab of Category
            cmbStock.DisplayMember = "Name";
            cmbStock.ValueMember = "SID";
            cmbStock.DataSource = StockServices.GetStocks();

            FillCategoryGrid();

            //Tab of Item
            cmbStockItem.DisplayMember = "Name";
            cmbStockItem.ValueMember = "SID";
            cmbStockItem.DataSource = StockServices.GetStocks();

            dtgridItem.DataSource = ItemServices.GetItems();

            //dtgridCategory.DataSource = CategoryServices.GetCategories();
        }

        private void FillCategoryGrid()
        {
            if(CategoriesInStockServices.GetCategoriesInStock((int)cmbStock.SelectedValue) != null && cmbStock.SelectedValue != null)
                dtgridCategory.DataSource = CategoriesInStockServices.GetCategoriesInStock((int)cmbStock.SelectedValue);
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            
            Stock stock = new Stock();
            stock.Name = txtStock.Text;
            StockServices.AddStock(stock);
            MessageBox.Show("Done");
            dtgridStock.DataSource = StockServices.GetStocks();
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        { 
            int id= (int)dtgridStock.CurrentRow.Cells[0].Value;
            StockServices.EditStock(id,txtStock.Text);
            MessageBox.Show("Done");
            dtgridStock.DataSource = StockServices.GetStocks();
        }

        private void btnDeleteStock_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgridStock.SelectedCells[0].Value.ToString());
            StockServices.DeleteStock(id);
            MessageBox.Show("Done");
            dtgridStock.DataSource = StockServices.GetStocks();
        }

        private void dtgridStock_SelectionChanged(object sender, EventArgs e)
        {
            Stock stock = (Stock)dtgridStock.CurrentRow.DataBoundItem;

            txtStock.Text = stock.Name;

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            //Add to Category Table
            Category category = new Category();
            category.Name = txtCategory.Text;
            CategoryServices.AddCategory(category);

            //Add To CategoriesInStock Table
            CategoriesInStock categoriesInStock = new CategoriesInStock();
            categoriesInStock.SID = (int)cmbStock.SelectedValue;
            categoriesInStock.CID = category.CID;            
            CategoriesInStockServices.AddCategoryInStock(categoriesInStock);

            MessageBox.Show("Done");
            FillCategoryGrid();
            //dtgridCategory.DataSource = CategoryServices.GetCategories();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            int id = (int)dtgridCategory.CurrentRow.Cells[0].Value;
            CategoryServices.EditCategory(id, txtCategory.Text);
            MessageBox.Show("Done");
            dtgridCategory.DataSource = CategoryServices.GetCategories();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgridCategory.SelectedCells[0].Value.ToString());
            CategoryServices.DeleteCategory(id);
            MessageBox.Show("Done");
            dtgridCategory.DataSource = CategoryServices.GetCategories();
        }

        private void dtgridCategory_SelectionChanged(object sender, EventArgs e)
        {
            //Category category = (Category)dtgridCategory.CurrentRow.DataBoundItem;

            //txtCategory.Text = category.Name;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            item.Name = txtItem.Text;
            item.CSID = (int)cmbCategoryItem.SelectedValue;

            ItemServices.AddItem(item);
            MessageBox.Show("Done");
            dtgridItem.DataSource = ItemServices.GetItems();
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            int id = (int)dtgridItem.CurrentRow.Cells[0].Value;
            ItemServices.EditItem(id, txtItem.Text);
            MessageBox.Show("Done");
            dtgridItem.DataSource = ItemServices.GetItems();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(dtgridItem.SelectedCells[0].Value.ToString());
            CategoryServices.DeleteCategory(id);
            MessageBox.Show("Done");
            dtgridItem.DataSource = ItemServices.GetItems();
        }

        private void dtgridItem_SelectionChanged(object sender, EventArgs e)
        {
            //Item item = (Item)dtgridItem.CurrentRow.DataBoundItem;

            //txtItem.Text = item.Name;
        }

        private void cmbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCategoryGrid();
        }

        private void cmbStockItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCategoryItem.DisplayMember = "Category";
            cmbCategoryItem.ValueMember = "ID";
            cmbCategoryItem.DataSource = CategoriesInStockServices.GetCategoriesInStock((int)cmbStockItem.SelectedValue);
        }
    }
}
