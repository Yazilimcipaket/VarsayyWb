using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsayyWeb
{
    public class DtoKullanici
    {
        public string _id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Eposta { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Parola { get; set; }
        public DateTime createdAt { get; set; }
        public int __v { get; set; }
    }
}