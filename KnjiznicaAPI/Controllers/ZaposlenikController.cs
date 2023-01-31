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
    public class ZaposlenikController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Get(int knjiznicaId)
        {
            IList<ZaposlenikViewModel> data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                data = ctx.Zaposleniks.Where(w => w.KnjiznicaID == knjiznicaId)
                            .Select(s => new ZaposlenikViewModel()
                            {

                                ID = s.ID,
                                Ime = s.Ime,
                                Prezime = s.Prezime,
                                Email = s.Email,
                                Sifra = s.Sifra,
                                KontaktBroj = s.KontaktBroj,
                                PocetakRada = s.PocetakRada,
                                KnjiznicaID = s.KnjiznicaID


                            }).ToList();
            }

            if (data.Count == 0)
            {
                return NotFound();
            }

            return Ok(data);
        }
        [HttpPost]
        public IHttpActionResult Post(ZaposlenikViewModel zaposlenikVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {
                var data = new Zaposlenik();

                data.KnjiznicaID = zaposlenikVM.KnjiznicaID;

                data.Ime = zaposlenikVM.Ime;
                data.Prezime = zaposlenikVM.Prezime;
                data.KontaktBroj = zaposlenikVM.KontaktBroj;
                data.Email = zaposlenikVM.Email;
                data.Sifra = zaposlenikVM.Sifra;
                data.PocetakRada = zaposlenikVM.PocetakRada;

                ctx.Zaposleniks.Add(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(ZaposlenikViewModel zaposlenikVM)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Zaposleniks
                    .Where(w => w.ID == zaposlenikVM.ID).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                //data.KnjiznicaID = zaposlenikVM.KnjiznicaID;
                //data.ID = zaposlenikVM.ID;
                data.Ime = zaposlenikVM.Ime;
                data.Prezime = zaposlenikVM.Prezime;
                data.KontaktBroj = zaposlenikVM.KontaktBroj;
                data.Email = zaposlenikVM.Email;
                data.Sifra = zaposlenikVM.Sifra;
                data.PocetakRada = zaposlenikVM.PocetakRada;


                ctx.SaveChanges();
            }

            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            using (var ctx = new DBKnjiznicaEntities())
            {

                var data = ctx.Zaposleniks
                    .Where(w => w.ID == id).SingleOrDefault();

                if (data == null)
                {
                    return NotFound();
                }

                ctx.Zaposleniks.Remove(data);

                ctx.SaveChanges();
            }

            return Ok();
        }
        [HttpGet]
        public IHttpActionResult GetForLogin(String email, int sifra)
        {
            ZaposlenikViewModel data = null;

            using (var ctx = new DBKnjiznicaEntities())
            {
                data = ctx.Zaposleniks.Where(w => w.Email == email && w.Sifra == sifra)
                            .Select(s => new ZaposlenikViewModel()
                            {

                                ID = s.ID,
                                Ime = s.Ime,
                                Prezime = s.Prezime,
                                Email = s.Email,
                                Sifra = s.Sifra,
                                KontaktBroj = s.KontaktBroj,
                                PocetakRada = s.PocetakRada,
                                KnjiznicaID = s.KnjiznicaID


                            }).SingleOrDefault();
            }

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }
    }
}
