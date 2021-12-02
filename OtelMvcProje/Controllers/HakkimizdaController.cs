using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OtelMvcProje.Models.Entity;

namespace OtelMvcProje.Controllers
{
    public class HakkimizdaController : Controller
    {
        DbOtelEntitiess db = new DbOtelEntitiess();
        public ActionResult Index()
        {
            var veriler = db.Hakkimizda.ToList();
            return View(veriler);
        }
    }
}