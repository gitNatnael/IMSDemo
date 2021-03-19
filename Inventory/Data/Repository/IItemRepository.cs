using Data.Model;
using System;
using System.Collections.Generic;

namespace Inventory.Data
{
    public interface IItemRepository<TEntity> :IDisposable where TEntity : class
    {
        List<TEntity> GetItems();
        TEntity GetItem(Guid id);
        void AddItem(TEntity item);
        void DeleteItem(Guid id);
    }
}
