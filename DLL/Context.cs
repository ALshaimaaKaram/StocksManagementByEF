using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DLL
{
    public class Context : DbContext
    {
        public Context()
            : base(@"Data Source=DESKTOP-QDTFMRF;Initial Catalog=Store;Integrated Security=True")
        {
                
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemExport> ItemExports { get; set; }
        public DbSet<ItemImport> ItemImports { get; set; }
        public DbSet<CategoriesInStock> CategoriesInStocks { get; set; }

    }
}
