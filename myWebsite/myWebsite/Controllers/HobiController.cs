using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myWebsite.Models.Entitiy;
using myWebsite.Repositories;

namespace myWebsite.Controllers
{
    public class HobiController : Controller
    {
        // GET: Hobi
        GenericRepository<Hobilerim> repo = new GenericRepository<Hobilerim>();
        [HttpGet]
        public ActionResult Index()
        {
            var hobiler = repo.List();
            return View(hobiler);
        }
        [HttpPost]
        public ActionResult Index(Hobilerim p)
        {
            /*Hobilerim t = new Hobilerim();*/
            var t = repo.Find(x => x.ID== 1);
            t.Aciklama = p.Aciklama;
            t.Aciklama2= p.Aciklama2;
            repo.TUpdate(t);
            return RedirectToAction("Index");
        }
    }
}