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
    public class MagistralsController : ApiController
    {
        private wsdemo8Entities1 db = new wsdemo8Entities1();

        // GET: api/Magistrals
        public IQueryable<Magistral> GetMagistral()
        {
            return db.Magistral;
        }

        // GET: api/Magistrals/5
        [ResponseType(typeof(Magistral))]
        public IHttpActionResult GetMagistral(int id)
        {
            Magistral magistral = db.Magistral.Find(id);
            if (magistral == null)
            {
                return NotFound();
            }

            return Ok(magistral);
        }

        // PUT: api/Magistrals/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMagistral(int id, Magistral magistral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != magistral.Id)
            {
                return BadRequest();
            }

            db.Entry(magistral).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MagistralExists(id))
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

        // POST: api/Magistrals
        [ResponseType(typeof(Magistral))]
        public IHttpActionResult PostMagistral(Magistral magistral)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Magistral.Add(magistral);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = magistral.Id }, magistral);
        }

        // DELETE: api/Magistrals/5
        [ResponseType(typeof(Magistral))]
        public IHttpActionResult DeleteMagistral(int id)
        {
            Magistral magistral = db.Magistral.Find(id);
            if (magistral == null)
            {
                return NotFound();
            }

            db.Magistral.Remove(magistral);
            db.SaveChanges();

            return Ok(magistral);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MagistralExists(int id)
        {
            return db.Magistral.Count(e => e.Id == id) > 0;
        }
    }
}