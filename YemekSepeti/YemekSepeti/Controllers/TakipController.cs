using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepeti.Models;

namespace YemekSepeti.Controllers
{
    public class TakipController : Controller
    {
        // GET: Takip
        YemekSiparisEntities2 db = new YemekSiparisEntities2();
        public ActionResult Index()
        {
            var query = db.Siparis.ToList();

            return View(query);
        }
    }
}