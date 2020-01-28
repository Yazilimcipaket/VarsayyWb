using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace VarsayyWeb.Controllers
{
    public class KullaniciController : Controller
    {
        DataBase Context = new DataBase();
        // GET: Kullanici
        public ActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GirisYap(Table_Kullanici kullanici)
        {
            var kullanic = Context.KullaniciGiris(kullanici.Adi, kullanici.Parola).FirstOrDefault(x=>x.Adi==kullanici.Adi&&x.Parola==kullanici.Parola);
            if (kullanic != null)
            {
                AktifKullanici.kullanici = Context.Table_Kullanici.FirstOrDefault(x => x.Adi == kullanici.Adi && x.Parola == kullanici.Parola);
                return RedirectToAction("Index","Home");
            }

            else
                return View();
        }
        public ActionResult CikisYap()
        {
            AktifKullanici.kullanici = null;
            Sepet.Urunler = null;
            return RedirectToAction("Index","Home");
        }
        public ActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KayitOl(Table_Kullanici kullanici)
        {
            Context.KullaniciKayit(kullanici.Adi, kullanici.Soyadi, kullanici.Eposta, kullanici.Parola);
            return RedirectToAction("Index", "Home");
        }
    }
}