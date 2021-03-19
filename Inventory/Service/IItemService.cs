using Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    
    public interface IItemService
    {
        List<Item> GetItems();
    }
}
