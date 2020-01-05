using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPT.Data_Access_Layer;
using UPT.ViewModels;

namespace UPT.Controllers
{
    public class HomeController : Controller
    {
        private ContextUniversitate db = new ContextUniversitate();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<GrupDataInscriere> data = from student in db.Studenti
                                                   group student by student.DataInscrierii into dataGrup
                                                   select new GrupDataInscriere()
                                                   {
                                                       DataInscrierii = dataGrup.Key,
                                                       NrStudenti = dataGrup.Count()
                                                   };
            return View(data.ToList());

        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}