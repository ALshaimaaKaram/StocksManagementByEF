using DLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class StockServices
    {
        Context context = new Context();
        public void AddStock(Stock stock)
        {
            context.Stocks.Add(stock);
            context.SaveChanges();
        }

        public void EditStock(int Id, string Name)
        {
            context.Stocks.Where(s => s.SID == Id).First().Name = Name;
            //stock.Name = Name;
            //context.Stocks.;
            context.SaveChanges();
        } 
        
        public void DeleteStock(int Id)
        {
            Stock stock = context.Stocks.Where(s => s.SID == Id).FirstOrDefault();
            context.Stocks.Remove(stock);
            context.SaveChanges();
        }

        public List<Stock> GetStocks()
        {
            return context.Stocks.ToList();
        }
    }
}
