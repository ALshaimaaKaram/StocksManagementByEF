using DLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class ItemServices
    {
        Context context = new Context();
        public void AddItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void EditItem(int Id, string Name)
        {
            context.Items.Where(i => i.ID == Id).First().Name = Name;
            context.SaveChanges();
        }

        public void DeleteItem(int Id)
        {
            Item item = context.Items.Where(i => i.ID == Id).FirstOrDefault();
            context.Items.Remove(item);
            context.SaveChanges();
        }

        //public List<Item> GetItems()
        //{

        //    return context.Items.ToList();
        //}



        public dynamic GetItems()
        {
            dynamic list = 
                    context.Items.Join(
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
                        }).ToList();

            return list;
        }

        public dynamic GetItemsByCSID(int CSID)
        {
            dynamic list =
                    context.Items.Where(csid => csid.CSID == CSID).Join(
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
                        }).ToList();

            return list;
        }
    }
}
