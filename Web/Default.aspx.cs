using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var giris = new Class.Kullanici().GetByKullanici(txt_mail.Text, txt_sifre.Text, drp_yetki.SelectedValue);
            var bilgi = giris.ds_kullanici_ad.ToString() + giris.ds_kullanici_soyad.ToString();
            Session["Bilgi"] = bilgi;
            if (giris != null)
            {
                Session["Giris"] = giris;
                if (giris.ds_kullanici_stili == "Ogrenci")
                    Response.Redirect("OgrenciAnasayfa");
                else if (giris.ds_kullanici_stili == "Hoca")
                    Response.Redirect("HocaAnasayfa");
            }
        }
            //if (chk_ogr.Checked == true && chk_hoca.Checked == false)
            //{
            //    var yetki = "Ogrenci";
            //    var giris = new Class.Kullanici().GetByKullanici(txt_mail.Text,txt_sifre.Text,yetki);
            //    var bilgi = giris.ds_kullanici_ad.ToString() + giris.ds_kullanici_soyad.ToString();
            //    Session["Giris"] = giris;
            //    Session["Bilgi"] = bilgi;
            //    if (giris.ds_kullanici_stili == yetki)
            //        Response.Redirect("Ogrenci/MasterOgrenci.aspx");        
            //}
            //else if ()
            //{
            //    var yetki = "Hoca";   
            //    var giris = new Class.Kullanici().GetByKullanici(txt_mail.Text, txt_sifre.Text, yetki);
            //    var bilgi = giris.ds_kullanici_ad.ToString()+giris.ds_kullanici_soyad.ToString();
            //    Session["Giris"] = giris;
            //    Session["Bilgi"] = bilgi;
            //    if (giris.ds_kullanici_stili == yetki)
            //        Response.Redirect("Hoca/MasterHoca.aspx");
            //}


        }

        //protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    DropDownList2.DataSource = new Class.Kullanici().Getir2(DropDownList1.SelectedIndex);
        //    DropDownList2.DataValueField = "ds_kullanici_id";
        //    DropDownList2.DataTextField = "ds_kullanici_ad";
        //    DropDownList2.DataBind();
        //}
}
