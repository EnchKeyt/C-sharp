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
using WebApplication2.Entities;

namespace WebApplication2.Controllers
{
    public class Seti_dostupaController : ApiController
    {
        private wsdemo8Entities1 db = new wsdemo8Entities1();

        // GET: api/Seti_dostupa
        public IQueryable<Seti_dostupa> GetSeti_dostupa()
        {
            return db.Seti_dostupa;
        }

        // GET: api/Seti_dostupa/5
        [ResponseType(typeof(Seti_dostupa))]
        public IHttpActionResult GetSeti_dostupa(int id)
        {
            Seti_dostupa seti_dostupa = db.Seti_dostupa.Find(id);
            if (seti_dostupa == null)
            {
                return NotFound();
            }

            return Ok(seti_dostupa);
        }

        // PUT: api/Seti_dostupa/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSeti_dostupa(int id, Seti_dostupa seti_dostupa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != seti_dostupa.Id)
            {
                return BadRequest();
            }

            db.Entry(seti_dostupa).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Seti_dostupaExists(id))
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

        // POST: api/Seti_dostupa
        [ResponseType(typeof(Seti_dostupa))]
        public IHttpActionResult PostSeti_dostupa(Seti_dostupa seti_dostupa)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Seti_dostupa.Add(seti_dostupa);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = seti_dostupa.Id }, seti_dostupa);
        }

        // DELETE: api/Seti_dostupa/5
        [ResponseType(typeof(Seti_dostupa))]
        public IHttpActionResult DeleteSeti_dostupa(int id)
        {
            Seti_dostupa seti_dostupa = db.Seti_dostupa.Find(id);
            if (seti_dostupa == null)
            {
                return NotFound();
            }

            db.Seti_dostupa.Remove(seti_dostupa);
            db.SaveChanges();

            return Ok(seti_dostupa);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Seti_dostupaExists(int id)
        {
            return db.Seti_dostupa.Count(e => e.Id == id) > 0;
        }
    }
}