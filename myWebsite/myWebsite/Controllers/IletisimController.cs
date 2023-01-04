using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myWebsite.Models.Entitiy;
using myWebsite.Repositories;

namespace myWebsite.Controllers
{
    public class IletisimController : Controller
    {
        // GET: Iletisim
        GenericRepository<Iletisim> repo = new GenericRepository<Iletisim>();
        public ActionResult Index()
        {
            var mesaj = repo.List();
            return View(mesaj);
        }
    }
}