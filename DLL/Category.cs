using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DLL
{
    public class Category
    {
        [Key]
        public int CID { get; set; }
        public string Name { get; set; }
        public List<CategoriesInStock> CategoriesInStocks { get; set; }
    }
}
