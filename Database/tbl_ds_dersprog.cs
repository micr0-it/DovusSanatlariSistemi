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
    
    public partial class tbl_ds_dersprog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ds_dersprog()
        {
            this.tbl_ds_kullanici = new HashSet<tbl_ds_kullanici>();
        }
    
        public byte ds_dersprog_id { get; set; }
        public string ds_dersprog_tarih { get; set; }
        public Nullable<byte> ds_dersprog_ders_fkid { get; set; }
        public Nullable<byte> ds_dersprog_adres_fkid { get; set; }
    
        public virtual tbl_ds_adres tbl_ds_adres { get; set; }
        public virtual tbl_ds_dersler tbl_ds_dersler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ds_kullanici> tbl_ds_kullanici { get; set; }
    }
}
