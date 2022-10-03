using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YemekSepeti.Models;

namespace YemekSepeti.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        YemekSiparisEntities2 db = new YemekSiparisEntities2();
        public ActionResult Index()
        {
            

            return View();
        }
        


        public ActionResult getAnaYemek()
        {
            var query = db.Yemeklers.ToList();
            return Json(query, JsonRequestBehavior.AllowGet);

        }
        public ActionResult getAraYemek()
        {
            var query = db.AraSicaklars.ToList();
            return Json(query, JsonRequestBehavior.AllowGet);

        }
        public ActionResult getIcecekler()
        {
            var query = db.Iceceklers.ToList();
            return Json(query, JsonRequestBehavior.AllowGet);

        }

        [HttpPost]
        public ActionResult SaveRules(SiparisViewModel model)
        {
            using (YemekSiparisEntities2 db = new YemekSiparisEntities2())
            {
                var ruleData = new Sipari()
                {
                    YemekAdi = model.YemekAdi,
                    AraSicakAdi = model.AraSicakAdi,
                    İcecekeler = model.İcecekeler
                    
                };

                
                db.Siparis.Add(ruleData);
                db.SaveChanges();
                return RedirectToAction("Index", "Anasayfa");
            }
        }
    }
}