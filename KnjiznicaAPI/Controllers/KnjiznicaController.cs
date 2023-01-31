﻿using KnjiznicaAPI.Models;
using KnjiznicaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnjiznicaAPI.Controllers
{
    public class KnjiznicaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get()
        {
            IList<KnjiznicaViewModel> data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                data = ctx.Knjiznicas
                            .Select(s => new KnjiznicaViewModel()
                            {
                                ID = s.ID,
                                NazivKnjiznice = s.NazivKnjiznice,
                                AdresaKnjiznice = s.AdresaKnjiznice

                            }).ToList();
            }

            if (data.Count == 0)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(KnjiznicaViewModel knjiznicaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {
                var data  = new Knjiznica();

                data.AdresaKnjiznice = knjiznicaVM.AdresaKnjiznice;
                data.NazivKnjiznice = knjiznicaVM.NazivKnjiznice;

                ctx.Knjiznicas.Add(data);
                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(KnjiznicaViewModel knjiznicaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Knjiznicas
                    .Where(w => w.ID == knjiznicaVM.ID).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                data.NazivKnjiznice = knjiznicaVM.NazivKnjiznice;
                data.AdresaKnjiznice = knjiznicaVM.AdresaKnjiznice;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Knjiznicas
                    .Where(w => w.ID == id).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                ctx.Knjiznicas.Remove(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }

}
