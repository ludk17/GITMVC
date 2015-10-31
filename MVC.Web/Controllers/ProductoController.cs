using MVC.Interfaces.Interfaces;
using MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Web.Controllers
{
    public class ProductoController : Controller
    {
        private InterfaceProducto repository;

        public ProductoController(InterfaceProducto repository)
        {
            this.repository = repository;
        }
   
        [HttpGet]
        public ViewResult Index()
        {            
            return View("Inicio", repository.All());
        }

       
    }
}
