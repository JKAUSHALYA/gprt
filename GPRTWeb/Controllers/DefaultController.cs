using GPRTWeb.Context;
using GPRTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;

namespace GPRTWeb.Controllers
{
    public class DefaultController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = db.Levels.Include(lvl => lvl.Modules);
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] List<Level> levels)
        {
            if (levels.Count() > 0)
            {
                var dbContext = new DatabaseContext();
                dbContext.Levels.AddRange(levels);
                dbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
