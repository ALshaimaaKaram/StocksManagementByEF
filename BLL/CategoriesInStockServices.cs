using DLL;
using System;
using System.Linq;

namespace BLL
{
    public class CategoriesInStockServices
    {
        Context context = new Context();

        public void AddCategoryInStock(CategoriesInStock categoriesInStock)
        {
            context.CategoriesInStocks.Add(categoriesInStock);
            context.SaveChanges();
        }
        public dynamic GetCategoriesInStock(int stockId)
        {
            dynamic list = context.CategoriesInStocks.Join(
                context.Categories,
                categoriesInStock => categoriesInStock.CID,
                category => category.CID,
                (categoriesInStock, category) => new
                {
                    categoriesInStock,
                    category
                }
                ).Join(
                context.Stocks.Where(st => st.SID == stockId),
                categoriesInStock => categoriesInStock.categoriesInStock.SID,
                stock => stock.SID,
                (categoriesInStock, stock) => new
                {
                    ID = categoriesInStock.categoriesInStock.ID,
                    Category = categoriesInStock.category.Name,
                    Stock = stock.Name
                }).ToList();

                return list;
        }
    }
}
