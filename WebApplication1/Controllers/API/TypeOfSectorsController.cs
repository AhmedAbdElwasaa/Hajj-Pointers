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
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    public class TypeOfSectorsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/TypeOfSectors
        public IQueryable<TypeOfSector> GetTypeOfSector()
        {
            return db.TypeOfSector;
        }

        // GET: api/TypeOfSectors/5
        [ResponseType(typeof(TypeOfSector))]
        public IHttpActionResult GetTypeOfSector(int id)
        {
            TypeOfSector typeOfSector = db.TypeOfSector.Find(id);
            if (typeOfSector == null)
            {
                return NotFound();
            }

            return Ok(typeOfSector);
        }

        // PUT: api/TypeOfSectors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTypeOfSector(int id, TypeOfSector typeOfSector)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != typeOfSector.Id)
            {
                return BadRequest();
            }

            db.Entry(typeOfSector).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TypeOfSectorExists(id))
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

        // POST: api/TypeOfSectors
        [ResponseType(typeof(TypeOfSector))]
        public IHttpActionResult PostTypeOfSector(TypeOfSector typeOfSector)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TypeOfSector.Add(typeOfSector);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = typeOfSector.Id }, typeOfSector);
        }

        // DELETE: api/TypeOfSectors/5
        [ResponseType(typeof(TypeOfSector))]
        public IHttpActionResult DeleteTypeOfSector(int id)
        {
            TypeOfSector typeOfSector = db.TypeOfSector.Find(id);
            if (typeOfSector == null)
            {
                return NotFound();
            }

            db.TypeOfSector.Remove(typeOfSector);
            db.SaveChanges();

            return Ok(typeOfSector);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TypeOfSectorExists(int id)
        {
            return db.TypeOfSector.Count(e => e.Id == id) > 0;
        }
    }
}