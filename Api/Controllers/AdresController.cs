using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class AdresController : ApiController
    {
        [HttpGet]
        public IEnumerable<Database.tbl_ds_adres> Get()
        {
            var adres = new Class.Adresler().Getir();
            return adres;
        }
    }
}
