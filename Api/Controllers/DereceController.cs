using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class DereceController : ApiController
    {
        [HttpGet]
        public IEnumerable<Database.tbl_ds_derece> Get()
        {
            var derece = new Class.Derece().Getir();
            return derece;
        }
    }
}
