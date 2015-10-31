using Moq;
using MVC.Interfaces.Interfaces;
using MVC.Models.Entities;
using MVC.Web.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MVC.Test.Controllers
{
    [TestFixture]
    public class ProductoControllerTest
    {
        [Test]
        public void TestIndexReturnView()
        {
            var mock = new Mock<InterfaceProducto>();
            mock.Setup(o => o.All()).Returns(new List<Producto>());

            var controller = new ProductoController(mock.Object);

            var view = controller.Index();

            Assert.IsInstanceOf(typeof(ViewResult), view);
            Assert.AreEqual("Inicio", view.ViewName);
            Assert.IsInstanceOf(typeof(List<Producto>), view.Model);
            
        }
    }
}
