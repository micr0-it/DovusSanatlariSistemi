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
    using System.Collections.Generic;
    
    public partial class tbl_ds_kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ds_kullanici()
        {
            this.tbl_ds_dersler = new HashSet<tbl_ds_dersler>();
        }
    
        public byte ds_kullanici_id { get; set; }
        public string ds_kullanici_stili { get; set; }
        public string ds_kullanici_ad { get; set; }
        public string ds_kullanici_soyad { get; set; }
        public Nullable<byte> ds_kullanici_adres { get; set; }
        public string ds_kullanici_yas { get; set; }
        public string ds_kullanici_sifre { get; set; }
        public Nullable<byte> ds_kullanici_dpfkid { get; set; }
        public Nullable<byte> ds_kullanici_derece_fkid { get; set; }
        public string ds_kullanici_posta { get; set; }
        public Nullable<byte> ds_kullanici_dersfkid { get; set; }
        public Nullable<bool> ds_kullanici_aktif { get; set; }
    
        public virtual tbl_ds_adres tbl_ds_adres { get; set; }
        public virtual tbl_ds_derece tbl_ds_derece { get; set; }
        public virtual tbl_ds_dersprog tbl_ds_dersprog { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ds_dersler> tbl_ds_dersler { get; set; }
    }
}