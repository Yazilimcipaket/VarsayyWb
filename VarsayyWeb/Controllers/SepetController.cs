using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace VarsayyWeb.Controllers
{
    public class SepetController : Controller
    {
        // GET: Sepet
        Sepet sepet;
        DataBase context = new DataBase();
        public ActionResult Index()
        {
            if (TempData["qr"] != null)
            {
                ViewBag.qr = TempData["qr"];
            }
            return View(Sepet.Urunler);
        }
        public ActionResult SepeteEkle(int id)
        {
            if(sepet==null)
                sepet = new Sepet();
            if (AktifKullanici.kullanici != null)
            {
                Table_Urun urun = context.Table_Urun.FirstOrDefault(x => x.Urunid == id);
                Sepet.Urunler.Add(urun);
                Sepet.Kullanici = AktifKullanici.kullanici;
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index","Home");
        }
        public ActionResult QROlustur()
        {
            DtoSepet dtosepet = new DtoSepet();
            dtosepet.sepet = new List<DtoUrun>();
            DtoUrun dtourun = null;
            foreach (Table_Urun item in Sepet.Urunler)
            {
                dtourun = new DtoUrun();
                dtourun.UrunMarka =  item.Table_Marka.Adi;
                dtourun.UrunAdi = item.Adi;
                dtourun.UrunFiyat = (int)item.Fiyat;
                dtourun.UrunSiteDomain = "Varsayy.com";
                dtosepet.sepet.Add(dtourun);
            }
            
            string result;
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(dtosepet);
            using (WebClient client = new WebClient())
            {
                try
                {
                    NameValueCollection Data = new NameValueCollection();
                    Data.Add("sepet", jsonString);
                    string postUrl = "http://soaproje.herokuapp.com/qrolustur";
                    byte[] gelenYanit = client.UploadValues(postUrl, "POST", Data);
                    result = System.Text.Encoding.UTF8.GetString(gelenYanit);
                    TempData["qr"] = result;
                }
                catch (Exception)
                {

                }

            }
            
            return RedirectToAction("Index");
        }
        
    }
}