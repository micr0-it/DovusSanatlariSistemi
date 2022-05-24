using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class DersProgramiController : ApiController
    {
        [HttpGet]
        public IEnumerable<Database.tbl_ds_dersprog> Get()
        {
            var dersprog = new Class.DersProgrami().Getir();
            return dersprog;
        }

    }
}
