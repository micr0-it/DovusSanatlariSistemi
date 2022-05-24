using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Url(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
        void Url(RouteCollection routes)
        {
            routes.MapPageRoute("Anasayfa", "GirisYap", "~/Default.aspx");
            routes.MapPageRoute("Hoca", "HocaAnasayfa", "~/Hoca/MasterHoca.aspx");
            routes.MapPageRoute("Ogrenci", "OgrenciAnasayfa", "~/Ogrenci/MasterOgrenci.aspx");
            routes.MapPageRoute("Kaydol", "KayitOl", "~/KayitOl.aspx");
            routes.MapPageRoute("SifremiUnuttum", "SifremiUnuttum", "~/SifremiUnuttum.aspx");
        }
    }
}