using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace VarsayyWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        DataBase Context = new DataBase();
        public ActionResult UrunEkle()
        {
            ViewBag.Marka = Context.Table_Marka.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult UrunEkle(Table_Urun urun, HttpPostedFileBase fileUpload)
        {
            Context.UrunEkle(urun.Adi, urun.Fiyat, urun.Markaid);//stored procedure
            int urunid=Context.Table_Urun.FirstOrDefault(x => x.Adi == urun.Adi && x.Markaid == urun.Markaid && x.Fiyat == urun.Fiyat).Urunid;
            Image img = Image.FromStream(fileUpload.InputStream);
            Bitmap Resim = new Bitmap(img);
            Resim.Save(Server.MapPath("/UrunResim/" + fileUpload.FileName));
            Table_Resim resim = new Table_Resim();
            resim.Urunid = urunid;
            resim.ResimYol = "/UrunResim/" + fileUpload.FileName;
            Context.Table_Resim.Add(resim);
            Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}