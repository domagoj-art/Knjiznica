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
    public class PosudbaController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(string filter, int knjiznicaId)
        {
            IList<PosudbaAllViewModel> data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                if (String.IsNullOrEmpty(filter))
                {
                    data = ctx.Posudbas.Include("Knjiga").Include("Zaposlenik").Include("ClanKnjiznice")
                        .Where(w => w.KnjiznicaID == knjiznicaId)
                                .Select(s => new PosudbaAllViewModel()
                                {

                                    ID = s.ID,
                                    KnjiznicaID = s.KnjiznicaID,
                                    ClanID = s.ClanID,
                                    ZaposlenikID = s.ZaposlenikID,
                                    KnjigaID = s.KnjigaID,
                                    DatumPreuzimanja = s.DatumPreuzimanja,
                                    DatumVracanja = s.DatumVracanja,
                                    Clan = s.ClanKnjiznice.Ime + " " + s.ClanKnjiznice.Prezime,
                                    Knjiga = s.Knjiga.NazivKnjige + " " + s.Knjiga.Pisac,
                                    Zaposlenik = s.Zaposlenik.Ime + " " + s.Zaposlenik.Prezime,


                                }).ToList();
                }
                else
                {
                    data = ctx.Posudbas.Include("Knjiga").Include("Zaposlenik").Include("ClanKnjiznice")
                        .Where(w=> w.Knjiga.NazivKnjige.Contains(filter) && w.KnjiznicaID == knjiznicaId || 
                        w.ClanKnjiznice.Ime.Contains(filter) && w.KnjiznicaID == knjiznicaId || w.ClanKnjiznice.Prezime.Contains(filter) && w.KnjiznicaID == knjiznicaId)
                                .Select(s => new PosudbaAllViewModel()
                                {
                                    ID = s.ID,
                                    KnjiznicaID = s.KnjiznicaID,
                                    ClanID = s.ClanID,
                                    ZaposlenikID = s.ZaposlenikID,
                                    KnjigaID = s.KnjigaID,
                                    DatumPreuzimanja = s.DatumPreuzimanja,
                                    DatumVracanja = s.DatumVracanja,
                                    Clan = s.ClanKnjiznice.Ime + " " + s.ClanKnjiznice.Prezime,
                                    Knjiga = s.Knjiga.NazivKnjige + " " + s.Knjiga.Pisac,
                                    Zaposlenik = s.Zaposlenik.Ime + " " + s.Zaposlenik.Prezime
                                }).ToList();
                }
            }

            if (data.Count == 0)
            {
                return NotFound();
            }

            return Ok(data);
        }
        [HttpPost]
        public IHttpActionResult Post(PosudbaViewModel PosudbaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {
                var data = new Posudba();

                data.KnjiznicaID = PosudbaVM.KnjiznicaID;

                data.ZaposlenikID = PosudbaVM.ZaposlenikID;
                data.ClanID = PosudbaVM.ClanID;
                data.KnjigaID = PosudbaVM.KnjigaID;
                data.DatumPreuzimanja = PosudbaVM.DatumPreuzimanja;
                data.DatumVracanja = PosudbaVM.DatumVracanja;


                ctx.Posudbas.Add(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(PosudbaViewModel PosudbaVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Posudbas
                    .Where(w => w.ID == PosudbaVM.ID).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                //data.KnjiznicaID = PosudbaVM.KnjiznicaID;
                //data.ID = PosudbaVM.ID;
                data.ZaposlenikID = PosudbaVM.ZaposlenikID;
                data.ClanID = PosudbaVM.ClanID;
                data.KnjigaID = PosudbaVM.KnjigaID;
                data.DatumPreuzimanja = PosudbaVM.DatumPreuzimanja;
                data.DatumVracanja = PosudbaVM.DatumVracanja;


                ctx.SaveChanges();
            }

            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Posudbas
                    .Where(w => w.ID == id).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                ctx.Posudbas.Remove(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
    }
}
