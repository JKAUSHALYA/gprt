using GPRTWeb.Context;
using GPRTWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace GPRTWeb.Controllers
{
    public class DefaultController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = db.Levels
                .Include(lvl => lvl.Modules)
                .Select(lvl => new { lvl.LevelName, lvl.Modules });
            return Ok(result);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] List<Level> levels)
        {
            if (levels.Count() > 0)
            {
                var dbContext = new DatabaseContext();
                foreach (var level in levels)
                {
                    dbContext.Levels.AddOrUpdate(lvl => lvl.LevelName, level);
                    dbContext.SaveChanges();

                    foreach (var module in level.Modules)
                    {
                        var dbModule = dbContext.Modules
                            .Include(mdl => mdl.Level)
                            .Where(mdl =>
                                mdl.Level.LevelName == level.LevelName &&
                                    mdl.ModuleName == module.ModuleName)
                            .FirstOrDefault();
                        if (dbModule != null)
                        {
                            dbModule.ActualMark = module.ActualMark;
                            dbModule.PredictedMark = module.PredictedMark;
                        }
                        else
                        {
                            dbContext.Levels
                                .SingleOrDefault(lvl => lvl.LevelName == level.LevelName)
                                .Modules
                                .Add(module);
                        }
                    }
                }
                dbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
