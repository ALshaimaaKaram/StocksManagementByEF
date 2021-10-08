using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DLL
{
    public class Stock
    {
        [Key]
        public int SID { get; set; }
        public string Name { get; set; }
        public virtual List<CategoriesInStock> CategoriesInStocks { get; set; }
    }
}
