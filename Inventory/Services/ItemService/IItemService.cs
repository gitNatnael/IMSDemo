using Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ItemService
{
   public interface IItemService
    {
        List<Item> GetItems();
    }
}
