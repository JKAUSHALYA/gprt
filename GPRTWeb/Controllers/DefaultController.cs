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
                .Include("Modules.Assesments")
                .Select(lvl => new
                {
                    lvl.LevelName,
                    Modules = lvl.Modules
                    .Select(mdl => new { mdl.Title, mdl.Code, mdl.CreditValue, mdl.Assesments})
                });
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
                                    mdl.Title.Equals(module.Title))
                            .FirstOrDefault();
                        if (dbModule != null)
                        {
                            dbModule.Code = module.Code;
                            dbModule.CreditValue = module.CreditValue;
                        }
                        else
                        {
                            dbContext.Levels
                                .Include(lvl => lvl.Modules)
                                .SingleOrDefault(lvl => lvl.LevelName == level.LevelName)
                                .Modules
                                .Add(module);
                            dbContext.SaveChanges();
                        }
                        foreach (var assesment in module.Assesments)
                        {
                            var dbAssesment = dbContext.Assesments
                                .Include(ast => ast.Module)
                                .Where(ast =>
                                    ast.Module.Title == module.Title &&
                                    ast.Name == assesment.Name)
                                .FirstOrDefault();
                            if (dbAssesment != null)
                            {
                                dbAssesment.PredictedMark = assesment.PredictedMark;
                                dbAssesment.ActualMark = assesment.ActualMark;
                            }
                            else
                            {
                                dbContext.Modules
                                    .Include(mdl => mdl.Assesments)
                                    .SingleOrDefault(mdl => mdl.Title == module.Title)
                                    .Assesments
                                    .Add(assesment);
                                dbContext.SaveChanges();
                            }
                        }
                    }
                }
                dbContext.SaveChanges();
            }
            return Ok();
        }
    }
}
