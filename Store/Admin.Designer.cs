
namespace Store
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabStock = new System.Windows.Forms.TabPage();
            this.dtgridStock = new System.Windows.Forms.DataGridView();
            this.btnDeleteStock = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.cmbStock = new System.Windows.Forms.ComboBox();
            this.dtgridCategory = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.cmbCategoryItem = new System.Windows.Forms.ComboBox();
            this.cmbStockItem = new System.Windows.Forms.ComboBox();
            this.dtgridItem = new System.Windows.Forms.DataGridView();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.lblstockItem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tab.SuspendLayout();
            this.tabStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridStock)).BeginInit();
            this.tabCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCategory)).BeginInit();
            this.tabItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabStock);
            this.tab.Controls.Add(this.tabCategory);
            this.tab.Controls.Add(this.tabItem);
            this.tab.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tab.Location = new System.Drawing.Point(8, 14);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(421, 371);
            this.tab.TabIndex = 0;
            // 
            // tabStock
            // 
            this.tabStock.Controls.Add(this.dtgridStock);
            this.tabStock.Controls.Add(this.btnDeleteStock);
            this.tabStock.Controls.Add(this.btnEditStock);
            this.tabStock.Controls.Add(this.btnAddStock);
            this.tabStock.Controls.Add(this.txtStock);
            this.tabStock.Controls.Add(this.lblStock);
            this.tabStock.Location = new System.Drawing.Point(4, 32);
            this.tabStock.Name = "tabStock";
            this.tabStock.Padding = new System.Windows.Forms.Padding(3);
            this.tabStock.Size = new System.Drawing.Size(413, 335);
            this.tabStock.TabIndex = 0;
            this.tabStock.Text = "Stock";
            this.tabStock.UseVisualStyleBackColor = true;
            // 
            // dtgridStock
            // 
            this.dtgridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridStock.Location = new System.Drawing.Point(43, 75);
            this.dtgridStock.Name = "dtgridStock";
            this.dtgridStock.RowTemplate.Height = 25;
            this.dtgridStock.Size = new System.Drawing.Size(245, 150);
            this.dtgridStock.TabIndex = 15;
            this.dtgridStock.SelectionChanged += new System.EventHandler(this.dtgridStock_SelectionChanged);
            // 
            // btnDeleteStock
            // 
            this.btnDeleteStock.Location = new System.Drawing.Point(156, 231);
            this.btnDeleteStock.Name = "btnDeleteStock";
            this.btnDeleteStock.Size = new System.Drawing.Size(85, 37);
            this.btnDeleteStock.TabIndex = 12;
            this.btnDeleteStock.Text = "Delete";
            this.btnDeleteStock.UseVisualStyleBackColor = true;
            this.btnDeleteStock.Click += new System.EventHandler(this.btnDeleteStock_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(53, 231);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(85, 37);
            this.btnEditStock.TabIndex = 13;
            this.btnEditStock.Text = "Edit";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(248, 24);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(85, 37);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(81, 28);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(145, 31);
            this.txtStock.TabIndex = 11;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(16, 28);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(55, 25);
            this.lblStock.TabIndex = 10;
            this.lblStock.Text = "Stock";
            // 
            // tabCategory
            // 
            this.tabCategory.Controls.Add(this.cmbStock);
            this.tabCategory.Controls.Add(this.dtgridCategory);
            this.tabCategory.Controls.Add(this.btnDeleteCategory);
            this.tabCategory.Controls.Add(this.btnEditCategory);
            this.tabCategory.Controls.Add(this.btnAddCategory);
            this.tabCategory.Controls.Add(this.txtCategory);
            this.tabCategory.Controls.Add(this.label3);
            this.tabCategory.Controls.Add(this.label2);
            this.tabCategory.Location = new System.Drawing.Point(4, 32);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategory.Size = new System.Drawing.Size(413, 335);
            this.tabCategory.TabIndex = 1;
            this.tabCategory.Text = "Category";
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // cmbStock
            // 
            this.cmbStock.FormattingEnabled = true;
            this.cmbStock.Location = new System.Drawing.Point(80, 25);
            this.cmbStock.Name = "cmbStock";
            this.cmbStock.Size = new System.Drawing.Size(145, 31);
            this.cmbStock.TabIndex = 10;
            this.cmbStock.SelectedIndexChanged += new System.EventHandler(this.cmbStock_SelectedIndexChanged);
            // 
            // dtgridCategory
            // 
            this.dtgridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridCategory.Location = new System.Drawing.Point(25, 112);
            this.dtgridCategory.Name = "dtgridCategory";
            this.dtgridCategory.RowTemplate.Height = 25;
            this.dtgridCategory.Size = new System.Drawing.Size(307, 150);
            this.dtgridCategory.TabIndex = 9;
            this.dtgridCategory.SelectionChanged += new System.EventHandler(this.dtgridCategory_SelectionChanged);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(155, 276);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(85, 37);
            this.btnDeleteCategory.TabIndex = 6;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(52, 276);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(85, 37);
            this.btnEditCategory.TabIndex = 7;
            this.btnEditCategory.Text = "Edit";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(247, 69);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(85, 37);
            this.btnAddCategory.TabIndex = 8;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(80, 73);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(145, 31);
            this.txtCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category";
            // 
            // tabItem
            // 
            this.tabItem.Controls.Add(this.cmbCategoryItem);
            this.tabItem.Controls.Add(this.cmbStockItem);
            this.tabItem.Controls.Add(this.dtgridItem);
            this.tabItem.Controls.Add(this.btnDeleteItem);
            this.tabItem.Controls.Add(this.btnEditItem);
            this.tabItem.Controls.Add(this.btnAddItem);
            this.tabItem.Controls.Add(this.txtItem);
            this.tabItem.Controls.Add(this.label);
            this.tabItem.Controls.Add(this.lblstockItem);
            this.tabItem.Controls.Add(this.label1);
            this.tabItem.Location = new System.Drawing.Point(4, 32);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(413, 335);
            this.tabItem.TabIndex = 2;
            this.tabItem.Text = "Item";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // cmbCategoryItem
            // 
            this.cmbCategoryItem.FormattingEnabled = true;
            this.cmbCategoryItem.Location = new System.Drawing.Point(280, 29);
            this.cmbCategoryItem.Name = "cmbCategoryItem";
            this.cmbCategoryItem.Size = new System.Drawing.Size(118, 31);
            this.cmbCategoryItem.TabIndex = 4;
            // 
            // cmbStockItem
            // 
            this.cmbStockItem.FormattingEnabled = true;
            this.cmbStockItem.Location = new System.Drawing.Point(66, 29);
            this.cmbStockItem.Name = "cmbStockItem";
            this.cmbStockItem.Size = new System.Drawing.Size(118, 31);
            this.cmbStockItem.TabIndex = 4;
            this.cmbStockItem.SelectedIndexChanged += new System.EventHandler(this.cmbStockItem_SelectedIndexChanged);
            // 
            // dtgridItem
            // 
            this.dtgridItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridItem.Location = new System.Drawing.Point(22, 122);
            this.dtgridItem.Name = "dtgridItem";
            this.dtgridItem.RowTemplate.Height = 25;
            this.dtgridItem.Size = new System.Drawing.Size(376, 150);
            this.dtgridItem.TabIndex = 3;
            this.dtgridItem.SelectionChanged += new System.EventHandler(this.dtgridItem_SelectionChanged);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(152, 286);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(85, 37);
            this.btnDeleteItem.TabIndex = 2;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(49, 286);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(85, 37);
            this.btnEditItem.TabIndex = 2;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(244, 79);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(85, 37);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(77, 83);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(145, 31);
            this.txtItem.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(190, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Category";
            // 
            // lblstockItem
            // 
            this.lblstockItem.AutoSize = true;
            this.lblstockItem.Location = new System.Drawing.Point(6, 29);
            this.lblstockItem.Name = "lblstockItem";
            this.lblstockItem.Size = new System.Drawing.Size(55, 25);
            this.lblstockItem.TabIndex = 0;
            this.lblstockItem.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 387);
            this.Controls.Add(this.tab);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tab.ResumeLayout(false);
            this.tabStock.ResumeLayout(false);
            this.tabStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridStock)).EndInit();
            this.tabCategory.ResumeLayout(false);
            this.tabCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridCategory)).EndInit();
            this.tabItem.ResumeLayout(false);
            this.tabItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabStock;
        private System.Windows.Forms.Button btnDeleteStock;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TabPage tabCategory;
        private System.Windows.Forms.DataGridView dtgridCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.DataGridView dtgridItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgridStock;
        private System.Windows.Forms.ComboBox cmbStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoryItem;
        private System.Windows.Forms.ComboBox cmbStockItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblstockItem;
    }
}