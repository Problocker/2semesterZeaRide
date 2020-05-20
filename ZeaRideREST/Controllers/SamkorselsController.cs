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
using ZeaRideREST.Models;

namespace ZeaRideREST.Controllers
{
    public class SamkorselsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Samkorsels
        public IQueryable<Samkorsel> GetSamkorsel()
        {
            return db.Samkorsel;
        }

        // GET: api/Samkorsels/5
        [ResponseType(typeof(Samkorsel))]
        public IHttpActionResult GetSamkorsel(int id)
        {
            Samkorsel samkorsel = db.Samkorsel.Find(id);
            if (samkorsel == null)
            {
                return NotFound();
            }

            return Ok(samkorsel);
        }

        // PUT: api/Samkorsels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSamkorsel(int id, Samkorsel samkorsel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != samkorsel.samkorselID)
            {
                return BadRequest();
            }

            db.Entry(samkorsel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SamkorselExists(id))
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

        // POST: api/Samkorsels
        [ResponseType(typeof(Samkorsel))]
        public IHttpActionResult PostSamkorsel(Samkorsel samkorsel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Samkorsel.Add(samkorsel);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (SamkorselExists(samkorsel.samkorselID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = samkorsel.samkorselID }, samkorsel);
        }

        // DELETE: api/Samkorsels/5
        [ResponseType(typeof(Samkorsel))]
        public IHttpActionResult DeleteSamkorsel(int id)
        {
            Samkorsel samkorsel = db.Samkorsel.Find(id);
            if (samkorsel == null)
            {
                return NotFound();
            }

            db.Samkorsel.Remove(samkorsel);
            db.SaveChanges();

            return Ok(samkorsel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SamkorselExists(int id)
        {
            return db.Samkorsel.Count(e => e.samkorselID == id) > 0;
        }
    }
}