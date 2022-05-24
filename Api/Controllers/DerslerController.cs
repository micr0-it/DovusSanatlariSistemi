using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class DerslerController : ApiController
    {
        [HttpGet]
        public IEnumerable<Database.tbl_ds_dersler> Get()
        {
            var dersler = new Class.Dersler().Getir();
            return dersler;
        }
    }
}
