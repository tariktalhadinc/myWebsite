using myWebsite.Models.Entitiy;
using myWebsite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myWebsite.Controllers
{
    public class DeneyimController : Controller
    {
        // GET: Deneyim
        DeneyimRepository repo = new DeneyimRepository();
        public ActionResult Index()
        {
            var deneyimler = repo.List();
            return View(deneyimler);
        }

        [HttpGet]
        public ActionResult DeneyimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeneyimEkle(Deneyimler p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult DeneyimSil(int id)
        {
            Deneyimler t = repo.Find(x => x.ID== id);
            repo.TDelete(t);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult DeneyimGetir(int id)
        {
            Deneyimler t = repo.Find(x => x.ID == id);
            return View(t);
        }
        [HttpPost]
        public ActionResult DeneyimGetir(Deneyimler p)
        {
            Deneyimler t = repo.Find(x => x.ID == p.ID);
            t.Baslik = p.Baslik;
            t.AltBaslik = p.AltBaslik;
            t.Aciklama = p.Aciklama;
            t.Tarih = p.Tarih;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}