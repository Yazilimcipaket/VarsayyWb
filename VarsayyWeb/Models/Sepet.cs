using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace VarsayyWeb
{
    public  class Sepet
    {
        public Sepet()
        {
            if (Urunler == null)
            {
                Urunler = new List<Table_Urun>();
            }
        }
        public static List<Table_Urun> Urunler;
        public static Table_Kullanici Kullanici { get; set; }
    }
}