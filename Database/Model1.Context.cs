//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DovusSanatlariEntities : DbContext
    {
        public DovusSanatlariEntities()
            : base("name=DovusSanatlariEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ds_adres> tbl_ds_adres { get; set; }
        public virtual DbSet<tbl_ds_derece> tbl_ds_derece { get; set; }
        public virtual DbSet<tbl_ds_dersler> tbl_ds_dersler { get; set; }
        public virtual DbSet<tbl_ds_dersprog> tbl_ds_dersprog { get; set; }
        public virtual DbSet<tbl_ds_kullanici> tbl_ds_kullanici { get; set; }
        public virtual DbSet<tbl_ds_menu> tbl_ds_menu { get; set; }
    }
}
