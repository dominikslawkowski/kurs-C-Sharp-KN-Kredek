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
using DominikSlawkowskiLab5.Models;

namespace DominikSlawkowskiLab5.Controllers
{
    public class DjsController : ApiController
    {
        private DominikSlawkowskiLab5Context db = new DominikSlawkowskiLab5Context();

        // GET: api/Djs
        public IQueryable<Dj> GetDjs()
        {
            return db.Djs;
        }

        // GET: api/Djs/5
        [ResponseType(typeof(Dj))]
        public async Task<IHttpActionResult> GetDj(int id)
        {
            Dj dj = await db.Djs.FindAsync(id);
            if (dj == null)
            {
                return NotFound();
            }

            return Ok(dj);
        }

        // PUT: api/Djs/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutDj(int id, Dj dj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != dj.Id)
            {
                return BadRequest();
            }

            db.Entry(dj).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DjExists(id))
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

        // POST: api/Djs
        [ResponseType(typeof(Dj))]
        public async Task<IHttpActionResult> PostDj(Dj dj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Djs.Add(dj);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = dj.Id }, dj);
        }

        // DELETE: api/Djs/5
        [ResponseType(typeof(Dj))]
        public async Task<IHttpActionResult> DeleteDj(int id)
        {
            Dj dj = await db.Djs.FindAsync(id);
            if (dj == null)
            {
                return NotFound();
            }

            db.Djs.Remove(dj);
            await db.SaveChangesAsync();

            return Ok(dj);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DjExists(int id)
        {
            return db.Djs.Count(e => e.Id == id) > 0;
        }
    }
}