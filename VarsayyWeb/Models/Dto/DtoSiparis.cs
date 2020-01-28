using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VarsayyWeb
{
    public class DtoSiparis
    {
        public List<DtoUrun> sepetim { get; set; }
        public List<string> sepet { get; set; }
        public string _id { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public string user_id { get; set; }
        public int __v { get; set; }
        public DtoKullanici kullanici { get; set; }
    }
}