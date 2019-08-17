using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Cantina.Controllers
{
    public class HomeController : Controller
    {
        private CantinaBanco db = new CantinaBanco();
        public ActionResult Index()
        {
            return View(db.Estoques.ToList());
        }

        // GET: Clientes/enviar/5
       [HttpPost]
        public ActionResult Index(int? id_produto)
        {

            Console.WriteLine(id_produto);
         
            Estoque estoque = db.Estoques.Find(id_produto);
            if (estoque == null)
            {
                return View();
            }


            return View(estoque);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}