using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Text.Json.Serialization;
using System.IO;
using System.Text;

namespace VarsayyWeb.Controllers
{
    public class SiparislerController : Controller
    {
        // GET: Siparisler
       
        public ActionResult Index()
        {
            string domain = "Varsayy.com";
            string adres = "http://soaproje.herokuapp.com/sitesiparis/siparisgetir?UrunSiteDomain=" + domain;
            WebRequest istek = HttpWebRequest.Create(adres);
            WebResponse cevap;
            cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            string bilgilerial = donenBilgiler.ReadToEnd();
            List<DtoSiparis> apiveri = new List<DtoSiparis>();
            apiveri = JsonConvert.DeserializeObject<List<DtoSiparis>>(bilgilerial);
            List<DtoUrun> urunler = new List<DtoUrun>();
            foreach (DtoSiparis item in apiveri)
            {
                item.sepetim = new List<DtoUrun>();
                urunler = JsonConvert.DeserializeObject<List<DtoUrun>>(item.sepet[0]);
                foreach (var item2 in urunler)
                {
                    item.sepetim.Add(item2);
                }
            }
            return View(apiveri);
        }
        public ActionResult SatinAl()
        {
            return View();
        }
    }
}