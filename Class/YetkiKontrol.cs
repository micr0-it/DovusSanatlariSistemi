using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Class
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:YetkiKontrol runat=server></{0}:YetkiKontrol>")]
    public class YetkiKontrol : System.Web.UI.Page
    {
        //[Bindable(true)]
        //[Category("Appearance")]
        //[DefaultValue("")]
        //[Localizable(true)]
        protected override void OnLoad(EventArgs e)
        {
            var yetki = (Database.tbl_ds_kullanici)System.Web.HttpContext.Current.Session["Giris"];
            if (yetki.ds_kullanici_stili == "Hoca")
                Response.Redirect("/Hoca/MasterHoca.aspx");
            else if (yetki.ds_kullanici_stili != "Ogrenci")
                Response.Redirect("/Default.aspx");
            base.OnLoad(e);
        }
    }
}
