using AdminkaAPI1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminkaAPI1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //чтобы протестировать создание базы данных
           // AppDbContext c = new AppDbContext();
           // c.Database.CreateIfNotExists();
                        
            return View();
        }
    }
}
