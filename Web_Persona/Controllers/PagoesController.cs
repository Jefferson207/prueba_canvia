using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Web_Persona.Models;

namespace Web_Persona.Controllers
{
    public class PagoesController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Pagoes
        public IQueryable<Pago> GetPagoes()
        {
            return db.Pagoes;
        }

        // GET: api/Pagoes/5
        [ResponseType(typeof(Pago))]
        public IHttpActionResult GetPago(int id)
        {
            Pago pago = db.Pagoes.Find(id);
            if (pago == null)
            {
                return NotFound();
            }

            return Ok(pago);
        }

        // PUT: api/Pagoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPago(int id, Pago pago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pago.IdPago)
            {
                return BadRequest();
            }

            db.Entry(pago).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Pagoes
        [ResponseType(typeof(Pago))]
        public IHttpActionResult PostPago(Pago pago)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pagoes.Add(pago);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pago.IdPago }, pago);
        }

        // DELETE: api/Pagoes/5
        [ResponseType(typeof(Pago))]
        public IHttpActionResult DeletePago(int id)
        {
            Pago pago = db.Pagoes.Find(id);
            if (pago == null)
            {
                return NotFound();
            }

            db.Pagoes.Remove(pago);
            db.SaveChanges();

            return Ok(pago);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PagoExists(int id)
        {
            return db.Pagoes.Count(e => e.IdPago == id) > 0;
        }
    }
}