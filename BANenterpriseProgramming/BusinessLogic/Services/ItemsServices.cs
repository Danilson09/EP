using DataAccess.Repositories;
using Domain.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Services
{
    public class ItemsServices
    {

        //note: when you need an instance of a class to be used in all the methods, you may use
        // dependency injection to ask for an instance and .net core will automatically
        // create an instance for you
        private ItemsRepository ItemRepository;
        public ItemsServices(ItemsRepository _itemRepository) //dependency injection
        {
            ItemRepository = _itemRepository;
        }

        public void AddNewItem(string name,string description,int rating,double price, int categoryid,int stock = 0 )
        {
            if (ItemRepository.GetItems().Where(x => x.Name == name).Count() > 0)
            {
                throw new Exception("item already exist. Use a different name");
            }

            ItemRepository.AddItem(new Domain.models.Item()
            {
                CategoryId = categoryid,
                Description = description,
                Name = name,
                Price = price,
                Stock = stock
            });
         
            

         
        }

        public void DeleteItem(int id)
        {
            var item = ItemRepository.GetItem(id);
            if (item != null) ItemRepository.DeleteItem(item);
        }


    }
}
