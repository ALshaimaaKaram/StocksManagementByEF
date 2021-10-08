using DLL;
using System;
using System.Linq;

namespace BLL
{
    public class ItemExportServices
    {
        Context context = new Context();
        public dynamic GetItemsExport()
        {
            dynamic Item = context.Items.Join(
                    context.CategoriesInStocks,
                    item => item.CSID,
                    categryInStocks => categryInStocks.ID,
                    (item, categryInStocks) => new
                    {
                        item,
                        categryInStocks
                    }).Join(
                       context.Categories,
                       categryInStocks => categryInStocks.categryInStocks.CID,
                       categry => categry.CID,
                       (categryInStocks, categry) => new
                       {
                           categryInStocks,
                           categry
                       }).Join(
                        context.Stocks,
                        categryInStocks => categryInStocks.categryInStocks.categryInStocks.SID,
                        stock => stock.SID,
                        (categryInStocks, stock) => new
                        {
                            ItemID = categryInStocks.categryInStocks.item.ID,
                            ItemName = categryInStocks.categryInStocks.item.Name,
                            CategoryName = categryInStocks.categryInStocks.categryInStocks.Category.Name,
                            StockName = stock.Name
                        }).Join(
                            context.ItemExports,
                             itemID => itemID.ItemID,
                             itemExports => itemExports.ItemID,
                            (itemID, itemExports) => new
                            {
                                itemID.ItemName,
                                itemID.CategoryName,
                                itemID.StockName,
                                itemExports.QuantityOut,
                                itemExports.DateOut
                            }).ToList();
            return Item;
        }


        public void AddItemExport(ItemExport itemExports)
        {
            context.ItemExports.Add(itemExports);
            context.SaveChanges();
        }
    }
}
