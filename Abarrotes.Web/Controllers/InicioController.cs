using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abarrotes.Web.Models;
namespace Abarrotes.Web.Controllers
{
    public class InicioController : Controller
    {
        // GET: Inicio
        public ActionResult Index()
        {
            List<Cliente> lista = 
                new List<Cliente>();
            lista.Add(new Cliente() {Id=1,Nombre="Gloria",Direccion="Teran",Telefono="9616112345",Edad=20 });
            lista.Add(new Cliente() { Id = 2, Nombre = "Erick", Direccion = "berrizabal", Telefono = "9616112345", Edad = 21 });
            lista.Add(new Cliente() { Id = 3, Nombre = "Luis", Direccion = "Coita", Telefono = "9616112345", Edad = 28 });
            ViewBag.totalClientes = lista.Count();
            ViewBag.Saludo = "Mi primer pagina MVC";
            return View();
        }
    }
}