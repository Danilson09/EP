using DataAccess.Context;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Repositories
{
    public class ItemsRepository
    {
        private ShoppingCartContext context;

        public ItemsRepository(ShoppingCartContext _context)
        {
            context = _context;
        }

        public void AddItem(Item i) 
        {
            context.Items.Add(i);
            context.SaveChanges(); // without this nothing will be saved into the database
        }

        public IQueryable<Item> GetItems()
        {
            return context.Items;
        }
        public Item GetItem(int id)
        {
            // i is a variable
            // => lambda expression
            // i == id the condition
            return GetItems().SingleOrDefault(i => i.Id == id);

            /*
             * foreach(item i in getItems())
             * {
             *      if(i.Id == id)
             *          return i;
             *        
             * }
             * return null
            */
        }

        public void DeleteItem(Item i)
        {
            context.Items.Remove(i);
            context.SaveChanges();
        }
    }
}
