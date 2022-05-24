using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class UserMenu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var yetki = (Database.tbl_ds_kullanici)System.Web.HttpContext.Current.Session["Giris"];
            var menu = new Class.Menuler().GetByYetki(yetki.ds_kullanici_stili).ToList();
            if (menu !=null)
            {
                string bilgi = "";
                for(int i = 0; i<menu.Count; i++)
                {
                    bilgi += "<li class=\"main-header navbar navbar-expand navbar-dark\">";
                    bilgi += "<a href = \"" + menu[i].ds_menu_nav_url + "\"class=\"nav-link\">";
                    bilgi += "<i class=\"nav-icon fas fa-th\"></i>";
                    bilgi += "<p>" + menu[i].ds_menu_ad + "";
                    bilgi += "<span class=\"right badge badge-danger\">New</span>";
                    bilgi += "</p></a></li>";
                }
                lt_menu.Text = bilgi;
            }
        }
    }
}