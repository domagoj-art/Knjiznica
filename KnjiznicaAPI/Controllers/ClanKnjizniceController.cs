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
    public class ClanKnjizniceController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int knjiznicaId)
        {
            IList<ClanKnjizniceViewModel> data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                data = ctx.ClanKnjiznices.Where(w => w.KnjiznicaID == knjiznicaId)
                            .Select(s => new ClanKnjizniceViewModel()
                            {
                                KnjiznicaID = s.KnjiznicaID,
                                ID = s.ID,
                                Ime = s.Ime,
                                Prezime = s.Prezime,
                                Email = s.Email,
                                KontaktBroj = s.KontaktBroj,
                                ClanarinaVrijediDo = s.ClanarinaVrijediDo


                            }).ToList();
            }

            if (data.Count == 0)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPost]
        public IHttpActionResult Post(ClanKnjizniceViewModel clanKnjizniceVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {
                var data = new ClanKnjiznice();

                data.KnjiznicaID = clanKnjizniceVM.KnjiznicaID;
                data.Ime = clanKnjizniceVM.Ime;
                data.Prezime = clanKnjizniceVM.Prezime;
                data.Email = clanKnjizniceVM.Email;
                data.KontaktBroj = clanKnjizniceVM.KontaktBroj;
                data.ClanarinaVrijediDo = clanKnjizniceVM.ClanarinaVrijediDo;


                ctx.ClanKnjiznices.Add(data);
                

                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put(ClanKnjizniceViewModel clanKnjizniceVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.ClanKnjiznices
                    .Where(w => w.ID == clanKnjizniceVM.ID).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }
                data.KnjiznicaID = clanKnjizniceVM.KnjiznicaID;
                data.ID = clanKnjizniceVM.ID;
                data.Ime = clanKnjizniceVM.Ime;
                data.Prezime = clanKnjizniceVM.Prezime;
                data.Email = clanKnjizniceVM.Email;
                data.KontaktBroj = clanKnjizniceVM.KontaktBroj;
                data.ClanarinaVrijediDo = clanKnjizniceVM.ClanarinaVrijediDo;
                ctx.SaveChanges();
            }

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.ClanKnjiznices
                    .Where(w => w.ID == id).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                ctx.ClanKnjiznices.Remove(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
