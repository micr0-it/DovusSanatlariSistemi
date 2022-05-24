using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Hoca
{
    public partial class DersProgrami : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sonuc = new Class.Menuler();
            var kullanici = new Database.tbl_ds_menu();
            Repeater1.DataSource = sonuc.Listele();
            Repeater1.DataBind();
        }

        protected void btn_goster_Click(object sender, EventArgs e)
        {
            var sonuc = new Class.DersProgrami();
            Repeater2.DataSource = sonuc.Listele();
            Repeater2.DataBind();
            
        }
    }
}