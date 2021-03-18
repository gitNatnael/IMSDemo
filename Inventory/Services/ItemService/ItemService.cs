using Data.Model;
using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ItemService
{
   public class ItemService 
    {
        private readonly IItemRepository _itemRepository;
        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public List<Item> GetItems()
        {
            return _itemRepository.GetItems();
        }
    }
}
