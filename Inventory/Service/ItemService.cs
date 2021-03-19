using Data.Model;
using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class ItemService
    {
        private readonly IItemRepository<Item> _itemRepository;
        public ItemService(IItemRepository<Item> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public IEnumerable<Item> GetItems()  {
            return _itemRepository.GetItems();
        }
    }
}
