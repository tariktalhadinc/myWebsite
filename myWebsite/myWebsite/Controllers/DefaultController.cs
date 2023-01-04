using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myWebsite.Models.Entitiy;

namespace myWebsite.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        myWebsiteEntities db = new myWebsiteEntities();
        public ActionResult Index()
        {
            var degerler = db.Hakkimdas.ToList();
            return View(degerler);
        }
        public PartialViewResult SosyalMedya()
        {
            var sosyalmedya = db.SosyalMedyas.Where(x => x.Durum == true).ToList();
            return PartialView(sosyalmedya);
        }
        public PartialViewResult Deneyim()
        {
            var deneyimler = db.Deneyimlers.ToList();
            return PartialView(deneyimler);
        }

        public PartialViewResult Egitimlerim()
        {
            var egitimler = db.Eğitimlerim.ToList();
            return PartialView(egitimler);
        }
        public PartialViewResult Yeteneklerim()
        {
            var yetenekler = db.Yeteneklers.ToList();
            return PartialView(yetenekler);
        }
        public PartialViewResult Hobilerim()
        {
            var hobiler = db.Hobilerims.ToList();
            return PartialView(hobiler);
        }
        public PartialViewResult Sertifikalar()
        {
            var sertifikalar = db.Sertifikalars.ToList();
            return PartialView(sertifikalar);
        }
        [HttpGet]
        public PartialViewResult Iletisim()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Iletisim(Iletisim t)
        {
            t.Tarih = DateTime.Parse( DateTime.Now.ToShortDateString());
            db.Iletisims.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}