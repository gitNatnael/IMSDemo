using Data.Model;
using Inventory.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.Test
{
    [TestClass]
   public class RepositoryTest
    {

        [TestMethod]
        public void GetItem()
        {
            Item newItem = new Item();
            newItem.ItemId = new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598");
            newItem.ItemName = "laptop";
            newItem.Price = 120;
            newItem.Quantity = 2;
            var repo = new Mock<IItemRepository>();
            repo.Setup(r => r.GetItem(new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598"))).Returns(newItem).Verifiable();
            var it = repo.Object.GetItem(new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598"));
            Assert.AreEqual(newItem, it);
        }

    }
}
