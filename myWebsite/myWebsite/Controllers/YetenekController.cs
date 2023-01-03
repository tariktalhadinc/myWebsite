using myWebsite.Models.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using myWebsite.Repositories;
using System.Web.Mvc;


namespace myWebsite.Controllers
{
    public class YetenekController : Controller
    {

        GenericRepository<Yetenekler> repo = new GenericRepository<Yetenekler>();
        public ActionResult Index()
        {
            var yetenekler = repo.List();
            return View(yetenekler);
        }

        [HttpGet]
        public ActionResult YeniYetenek()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniYetenek(Yetenekler p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
        public ActionResult YetenekSil(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            repo.TDelete(yetenek);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult YetenekDüzenle(int id)
        {
            var yetenek = repo.Find(x => x.ID == id);
            return  View(yetenek);
        }
        [HttpPost]
        public ActionResult YetenekDüzenle(Yetenekler t)
        {
            var y = repo.Find(x => x.ID == t.ID);
            y.Yetenek = t.Yetenek;
            y.Oran = t.Oran;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }
    }
}