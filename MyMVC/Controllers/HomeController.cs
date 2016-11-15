using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Site em MVC para teste de Integração continua AppVeyor";

            return View();
        }

        public ActionResult Contact()
        {
            usuario usu = new usuario {usu_id = 1, usu_nome = "Jonatas Lubec" };

            ViewBag.Message = "Segue Contato de " + usu.usu_nome;

            return View();
        }
    }
}
