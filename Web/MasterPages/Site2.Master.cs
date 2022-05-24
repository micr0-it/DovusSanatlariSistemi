using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.MasterPages
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void btn_islem_Click(object sender, EventArgs e)
        {
            var ders = new Database.tbl_ds_dersler();
            ders.ds_ders_adi = txt_dersad.Text;
            if(chk_ekle.Checked==true && chk_sil.Checked==false)
            {
                var sonuc = new Class.Dersler().AddDers(ders);
            }
            if (chk_ekle.Checked == false && chk_sil.Checked == true)
            {
                var sonuc = new Class.Dersler().DeleteDers(txt_dersad.Text,ders);
            }

        }
    
    }
}