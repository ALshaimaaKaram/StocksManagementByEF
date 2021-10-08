using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        [ForeignKey("CategoriesInStock")]
        public virtual int? CSID { get; set; }
        public virtual CategoriesInStock? CategoriesInStock { get; set; }
        public virtual List<ItemExport> ItemExports { get; set; }
        public virtual List<ItemImport> ItemImports { get; set; }
    }
}
