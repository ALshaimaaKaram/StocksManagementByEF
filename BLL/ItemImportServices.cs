using DLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ItemImportServices
    {
        Context context = new Context();
        public dynamic GetItemImports()
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
                            context.ItemImports,
                             itemID => itemID.ItemID,
                             itemImports => itemImports.ItemID,
                            (itemID, itemImports) => new
                            {
                                itemID.ItemName,
                                itemID.CategoryName,
                                itemID.StockName,
                                itemImports.QuantityIn,
                                itemImports.DateIn
                            }).ToList();
            return Item;
        }


        public void AddItemImport(ItemImport itemImport)
        {
            context.ItemImports.Add(itemImport);
            context.SaveChanges();
        }
    }
}
