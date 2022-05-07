using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication2.Entities;

namespace WebApplication2.Controllers
{
    public class SotrudnikisController : ApiController
    {
        private wsdemo8Entities db = new wsdemo8Entities();

        // GET: api/Sotrudnikis
        public IQueryable<Sotrudniki> GetSotrudniki()
        {
            return db.Sotrudniki;
        }

        // GET: api/Sotrudnikis/5
        [ResponseType(typeof(Sotrudniki))]
        public IHttpActionResult GetSotrudniki(int id)
        {
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            if (sotrudniki == null)
            {
                return NotFound();
            }

            return Ok(sotrudniki);
        }


 
        [HttpGet]
        [Route("api/Sotrudniki/Login ={login}/Password ={passwrd}")]
            public async  Task<IHttpActionResult> CheckLogi(string login, string password)
            {
            Sotrudniki sotrudniki = await db.Sotrudniki.Where(x => x.Login == login && x.Password == password).SingleOrDefaultAsync();
            if(sotrudniki == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(sotrudniki);
            }
            }


        // PUT: api/Sotrudnikis/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSotrudniki(int id, Sotrudniki sotrudniki)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sotrudniki.ID_sotrudnika)
            {
                return BadRequest();
            }

            db.Entry(sotrudniki).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SotrudnikiExists(id))
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

        // POST: api/Sotrudnikis
        [ResponseType(typeof(Sotrudniki))]
        public IHttpActionResult PostSotrudniki(Sotrudniki sotrudniki)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sotrudniki.Add(sotrudniki);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sotrudniki.ID_sotrudnika }, sotrudniki);
        }

        // DELETE: api/Sotrudnikis/5
        [ResponseType(typeof(Sotrudniki))]
        public IHttpActionResult DeleteSotrudniki(int id)
        {
            Sotrudniki sotrudniki = db.Sotrudniki.Find(id);
            if (sotrudniki == null)
            {
                return NotFound();
            }

            db.Sotrudniki.Remove(sotrudniki);
            db.SaveChanges();

            return Ok(sotrudniki);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SotrudnikiExists(int id)
        {
            return db.Sotrudniki.Count(e => e.ID_sotrudnika == id) > 0;
        }
    }
}