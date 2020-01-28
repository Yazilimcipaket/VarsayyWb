using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace VarsayyWeb.Controllers
{
    public class HomeController : Controller
    {
        DataBase Context = new DataBase();
       
        public ActionResult Index()
        {
            List<Table_Urun> urunler = new List<Table_Urun>();
            foreach (var item in Context.ViewUrunlers.ToList())
            {
                urunler.Add(Context.Table_Urun.FirstOrDefault(x => x.Urunid == item.Urunid));
            } 
            return View(urunler);
        }
    }
}