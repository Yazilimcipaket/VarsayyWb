//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VarsayyWeb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_Resim
    {
        public int Resimid { get; set; }
        public Nullable<int> Urunid { get; set; }
        public string ResimYol { get; set; }
    
        public virtual Table_Urun Table_Urun { get; set; }
    }
}