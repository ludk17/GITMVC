using DB;
using MVC.Models.Entities;
using MVC.Repositories.Repositories;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Test.Repositories
{
    [TestFixture]
    public class ProductoRespositorioTest
    {
        [Test]
        public void AllReturnListProducts()
        {
            var repo = new ProductoRepository(new MvcContext());

            var result = repo.All();

            Assert.IsInstanceOf(typeof(List<Producto>), result);
            Assert.AreEqual(5, result.Count());

        }
    }
}
