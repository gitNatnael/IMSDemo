using Data.Model;
using Inventory.Data;
using Inventory.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;


namespace Inventory.Test
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void GetItem()
        {
            Item newItem = new Item()
            {
                ItemId = new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598"),
                ItemName = "laptop",
                Price = 120,
                Quantity = 2
            };

            var repo = new Mock<IItemRepository<Item>>();
            repo.Setup(r => r.GetItem(new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598"))).Returns(newItem).Verifiable();
            var it = repo.Object.GetItem(new Guid("f4d2a513-7fc5-410c-a790-4e0cae455598"));
            Assert.AreEqual(newItem, it);
        }

    }
}
