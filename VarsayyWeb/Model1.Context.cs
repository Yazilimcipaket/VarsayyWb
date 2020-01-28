﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataBase : DbContext
    {
        public DataBase()
            : base("name=DataBase")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Table_Kullanici> Table_Kullanici { get; set; }
        public virtual DbSet<Table_Kullanici_Rol> Table_Kullanici_Rol { get; set; }
        public virtual DbSet<Table_Marka> Table_Marka { get; set; }
        public virtual DbSet<Table_Resim> Table_Resim { get; set; }
        public virtual DbSet<Table_Rol> Table_Rol { get; set; }
        public virtual DbSet<Table_Urun> Table_Urun { get; set; }
        public virtual DbSet<ViewUrunler> ViewUrunlers { get; set; }
    
        public virtual ObjectResult<KullaniciGiris_Result> KullaniciGiris(string kullaniciAdi, string kullaniciParola)
        {
            var kullaniciAdiParameter = kullaniciAdi != null ?
                new ObjectParameter("KullaniciAdi", kullaniciAdi) :
                new ObjectParameter("KullaniciAdi", typeof(string));
    
            var kullaniciParolaParameter = kullaniciParola != null ?
                new ObjectParameter("KullaniciParola", kullaniciParola) :
                new ObjectParameter("KullaniciParola", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<KullaniciGiris_Result>("KullaniciGiris", kullaniciAdiParameter, kullaniciParolaParameter);
        }
    
        public virtual int KullaniciKayit(string adi, string soyadi, string eposta, string parola)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("Adi", adi) :
                new ObjectParameter("Adi", typeof(string));
    
            var soyadiParameter = soyadi != null ?
                new ObjectParameter("Soyadi", soyadi) :
                new ObjectParameter("Soyadi", typeof(string));
    
            var epostaParameter = eposta != null ?
                new ObjectParameter("Eposta", eposta) :
                new ObjectParameter("Eposta", typeof(string));
    
            var parolaParameter = parola != null ?
                new ObjectParameter("Parola", parola) :
                new ObjectParameter("Parola", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("KullaniciKayit", adiParameter, soyadiParameter, epostaParameter, parolaParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UrunEkle(string adi, Nullable<int> fiyat, Nullable<int> markaid)
        {
            var adiParameter = adi != null ?
                new ObjectParameter("Adi", adi) :
                new ObjectParameter("Adi", typeof(string));
    
            var fiyatParameter = fiyat.HasValue ?
                new ObjectParameter("Fiyat", fiyat) :
                new ObjectParameter("Fiyat", typeof(int));
    
            var markaidParameter = markaid.HasValue ?
                new ObjectParameter("Markaid", markaid) :
                new ObjectParameter("Markaid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UrunEkle", adiParameter, fiyatParameter, markaidParameter);
        }
    }
}
