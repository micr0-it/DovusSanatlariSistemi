using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Api.Controllers
{
    public class KullaniciController : ApiController
    {
        // GET: Kullanici
        [HttpGet]
        public IEnumerable<Database.tbl_ds_kullanici> Get()
        {
            var kullanici = new Class.Kullanici().Getir();
            return kullanici;
        }
        
        [HttpPost]
        public string Ekle()
        {
            var kullanici = new Database.tbl_ds_kullanici();
            kullanici.ds_kullanici_ad = "Api Deneme2";
            kullanici.ds_kullanici_sifre = "Api Basarili2";
            var kullanici2 = new Class.Kullanici().AddKullanici(kullanici);
            return "1";
        }

    }
}