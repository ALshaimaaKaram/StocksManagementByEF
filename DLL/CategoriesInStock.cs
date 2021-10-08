using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DLL
{
    public class CategoriesInStock
    {
        public int ID { get; set; }
        [ForeignKey("Stock")]
        public virtual int SID { get; set; }
        [ForeignKey("Category")]
        public virtual int CID { get; set; }
        public virtual Stock Stock { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Item> Items { get; set; }

    }
}
