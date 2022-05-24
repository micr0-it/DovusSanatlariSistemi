using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            
            var sonuc = new Class.Kullanici();
            var kullanici = new Database.tbl_ds_kullanici();
            kullanici.ds_kullanici_ad = txt_ad.Text;
            kullanici.ds_kullanici_soyad = txt_soyad.Text;
            kullanici.ds_kullanici_posta = txt_mail.Text;
            kullanici.ds_kullanici_sifre = txt_sifre.Text;
            if (chk_ogr.Checked == true && chk_hoca.Checked == false)
                 kullanici.ds_kullanici_stili = "Ogrenci";
            else if (chk_ogr.Checked == false && chk_hoca.Checked == true)
                 kullanici.ds_kullanici_stili = "Hoca";
            sonuc.AddKullanici(kullanici);
            Response.Redirect("/Default.aspx");      
           
        }
    }
}