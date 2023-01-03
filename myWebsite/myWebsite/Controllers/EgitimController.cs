using myWebsite.Models.Entitiy;
using myWebsite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myWebsite.Controllers
{
    public class EgitimController : Controller
    {
        GenericRepository<Eğitimlerim> repo = new GenericRepository<Eğitimlerim>();

        public ActionResult Index()
        {
            var egitim = repo.List();
            return View(egitim);
        }
    }
}