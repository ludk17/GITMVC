using DB;
using MVC.Interfaces.Interfaces;
using MVC.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Repositories.Repositories
{
    public class ProductoRepository : InterfaceProducto
    {
        MvcContext entities;
        public ProductoRepository(MvcContext entities)
        {
            this.entities = entities;
        }
        public List<Producto> All()
        {
            var result = from p in entities.Productos select p;
            return result.ToList();
        }
    }
}
