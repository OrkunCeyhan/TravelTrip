using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip.Models.Sınıflar;
namespace TravelTrip.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context c = new Context(); //contex isimli sınıftan c isimli nesne türettik 
        public ActionResult Index()
        {
            var degerler = c.Hakkimizdas.ToList(); // c neesnesi yardımıylada contexte bağlı olan sınıflar içinde hakkımızda tablosuna ulasıp bu tabloyu listele dedik
            return View(degerler);
        }
    }
}