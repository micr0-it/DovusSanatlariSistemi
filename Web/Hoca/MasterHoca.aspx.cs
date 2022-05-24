using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Web.Hoca
{
    public partial class MasterHoca : System.Web.UI.Page //BURADA Class.YetkiKontrolden kalıtılabiliyor fakat tarayıcım çerez hatası verdiği için değiştirdim eski haline getirdim.
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //var hocaid = RouteData.Values["hoca_id"].ToString();
            //Session["hoca_id"] = hocaid;
            
            //Repeater ile veri çekme
            //var sonuc = new Class.Menuler();
            //var kullanici = new Database.tbl_ds_menu();
            //Repeater1.DataSource = sonuc.Listele();
            //Repeater1.DataBind();
            
            var kullanici = (Database.tbl_ds_kullanici)System.Web.HttpContext.Current.Session["Giris"]; 
            if (kullanici !=null)
            {
                lbl_adsoyad.Text = kullanici.ds_kullanici_ad + "" + kullanici.ds_kullanici_soyad;
                string bilgi = "";
                for (int i = 0; i < 1; i++)
                {
                    bilgi += "<li class=\"list-group-item\">";
                    bilgi += "<b>" + "Ders  " + kullanici.ds_kullanici_dersfkid+" - AİKİDO ";   
                    bilgi += "</b></li>";
                }
                Literal1.Text = bilgi;
            }           
          }
        protected void btn_guncelle_Click(object sender, EventArgs e)
        {
            var kullanici = new Database.tbl_ds_kullanici();
            kullanici.ds_kullanici_ad = txt_hocaisim.Text;
            kullanici.ds_kullanici_soyad = txt_hocasoyad.Text;
            if (txt_hocaders.Text == "KickBox")
                kullanici.ds_kullanici_derece_fkid = 6;
            //Burada arayüzde fkid ayarlamak için kullanıcı bilgilendir modal popupları çıkarabilirim
            var eylem = new Class.Kullanici().UpdateKullanici(txt_hocaisim.Text,kullanici);
        }
    }
}