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
    public class GenresController : ApiController
    {
        private DominikSlawkowskiLab5Context db = new DominikSlawkowskiLab5Context();

        // GET: api/Genres
        /// <summary>
        /// Pobieranie wszystkich gatunków muzycznych
        /// </summary>
        /// <returns></returns>
        public IQueryable<Genre> GetGenres()
        {
            var genres = from b in db.Genres
                        select new GenreDTO()
                        {
                            Id = b.Id,
                            Name = b.Name,
                            DjName = b.Dj.Name
                        };

            return db.Genres;
        }

        // GET: api/Genres/5
        /// <summary>
        /// Pobieranie gatunków muzycznych po zadanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(Genre))]
        public async Task<IHttpActionResult> GetGenre(int id)
        {
            var genre = await db.Genres.Include(b => b.Dj).Select(b =>
               new GenreDetailDTO()
               {
                   Id = b.Id,
                   Name = b.Name,
                   Year = b.Year,
                   BpmAmount = b.BpmAmount,
                   DjName = b.Dj.Name

               }).SingleOrDefaultAsync(b => b.Id == id);

            if (genre == null)
            {
                return NotFound();
            }

            return Ok(genre);
        }

        // PUT: api/Genres/5
        /// <summary>
        /// Edytowanie gatunku o zadanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="genre"></param>
        /// <returns></returns>
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutGenre(int id, Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != genre.Id)
            {
                return BadRequest();
            }

            db.Entry(genre).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GenreExists(id))
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

        // POST: api/Genres
        /// <summary>
        /// Dodawanie nowego gatunku
        /// </summary>
        /// <param name="genre"></param>
        /// <returns></returns>
        [ResponseType(typeof(Genre))]
        public async Task<IHttpActionResult> PostGenre(Genre genre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Genres.Add(genre);
            await db.SaveChangesAsync();

            // Load author name
            db.Entry(genre).Reference(x => x.Dj).Load();

            var dto = new GenreDTO()
            {
                Id = genre.Id,
                Name = genre.Name,
                DjName = genre.Dj.Name
            };

            return CreatedAtRoute("DefaultApi", new { id = genre.Id }, genre);
        }

        // DELETE: api/Genres/5
        /// <summary>
        /// Usuwanie gatunku o zadanym Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(Genre))]
        public async Task<IHttpActionResult> DeleteGenre(int id)
        {
            Genre genre = await db.Genres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            db.Genres.Remove(genre);
            await db.SaveChangesAsync();

            return Ok(genre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GenreExists(int id)
        {
            return db.Genres.Count(e => e.Id == id) > 0;
        }
    }
}