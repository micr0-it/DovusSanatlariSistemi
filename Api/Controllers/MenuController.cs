using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class MenuController : ApiController
    {
        [HttpGet]
        public IEnumerable<Database.tbl_ds_menu> Get()
        {
            var menu = new Class.Menuler().Getir();
            return menu;
        }

    }
}
