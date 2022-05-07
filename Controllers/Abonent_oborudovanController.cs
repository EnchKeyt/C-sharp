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
    public class Abonent_oborudovanController : ApiController
    {
        private wsdemo8Entities1 db = new wsdemo8Entities1();

        // GET: api/Abonent_oborudovan
        public IQueryable<Abonent_oborudovan> GetAbonent_oborudovan()
        {
            return db.Abonent_oborudovan;
        }

        // GET: api/Abonent_oborudovan/5
        [ResponseType(typeof(Abonent_oborudovan))]
        public IHttpActionResult GetAbonent_oborudovan(int id)
        {
            Abonent_oborudovan abonent_oborudovan = db.Abonent_oborudovan.Find(id);
            if (abonent_oborudovan == null)
            {
                return NotFound();
            }

            return Ok(abonent_oborudovan);
        }

        // PUT: api/Abonent_oborudovan/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAbonent_oborudovan(int id, Abonent_oborudovan abonent_oborudovan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != abonent_oborudovan.Id)
            {
                return BadRequest();
            }

            db.Entry(abonent_oborudovan).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Abonent_oborudovanExists(id))
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

        // POST: api/Abonent_oborudovan
        [ResponseType(typeof(Abonent_oborudovan))]
        public IHttpActionResult PostAbonent_oborudovan(Abonent_oborudovan abonent_oborudovan)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Abonent_oborudovan.Add(abonent_oborudovan);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = abonent_oborudovan.Id }, abonent_oborudovan);
        }

        // DELETE: api/Abonent_oborudovan/5
        [ResponseType(typeof(Abonent_oborudovan))]
        public IHttpActionResult DeleteAbonent_oborudovan(int id)
        {
            Abonent_oborudovan abonent_oborudovan = db.Abonent_oborudovan.Find(id);
            if (abonent_oborudovan == null)
            {
                return NotFound();
            }

            db.Abonent_oborudovan.Remove(abonent_oborudovan);
            db.SaveChanges();

            return Ok(abonent_oborudovan);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Abonent_oborudovanExists(int id)
        {
            return db.Abonent_oborudovan.Count(e => e.Id == id) > 0;
        }
    }
}