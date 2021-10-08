using DLL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CategoryServices
    {
        Context context = new Context();
        public void AddCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void EditCategory(int Id, string Name)
        {
            context.Categories.Where(c => c.CID == Id).First().Name = Name;
            context.SaveChanges();
        }

        public void DeleteCategory(int Id)
        {
            Category category = context.Categories.Where(c => c.CID == Id).FirstOrDefault();
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

    }
}