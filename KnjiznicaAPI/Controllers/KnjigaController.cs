using KnjiznicaAPI.Models;
using KnjiznicaAPI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnjiznicaAPI.Controllers
{
    public class KnjigaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int knjiznicaId)
        {
            IList<KnjigaViewModel> data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                data = ctx.Knjigas.Where(w => w.KnjiznicaID == knjiznicaId)
                            .Select(s => new KnjigaViewModel()
                            {
                                KnjiznicaID = s.KnjiznicaID,
                                ID = s.ID,
                                NazivKnjige = s.NazivKnjige,
                                Pisac = s.Pisac

                            }).ToList();
            }

            if (data.Count == 0)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(KnjigaViewModel knjigaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {
                var data = new Knjiga();

                data.NazivKnjige = knjigaVM.NazivKnjige;
                data.Pisac = knjigaVM.Pisac;
                data.KnjiznicaID = knjigaVM.KnjiznicaID;

                ctx.Knjigas.Add(data);
                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(KnjigaViewModel knjigaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Knjigas
                    .Where(w => w.ID == knjigaVM.ID).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                data.NazivKnjige = knjigaVM.NazivKnjige;
                data.Pisac = knjigaVM.Pisac;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Knjigas
                    .Where(w => w.ID == id).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                ctx.Knjigas.Remove(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
