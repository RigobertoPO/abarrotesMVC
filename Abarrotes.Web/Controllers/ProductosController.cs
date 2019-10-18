using Abarrotes.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abarrotes.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            List<Producto> lista =
                new List<Producto>();
            lista.Add(new Producto { Id = 1,Nombre = "Coca"});
            lista.Add(new Producto { Id = 2, Nombre = "Sabritas" });
            return View(lista);
        }
    }
}