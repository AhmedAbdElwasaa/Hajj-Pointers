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
using WebApplication1.Dto;
using WebApplication1.Models;

namespace WebApplication1.Controllers.API
{
    public class SectorsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Sectors
        public SectorsPageDto GetSectors()
        {
            SectorsPageDto sectorePageDTO = new SectorsPageDto();
            var sectors = db.Sectors.ToList();
            foreach (var item in sectors)
            {
                var typessect = db.TypeOfSector.Where(t => t.Sector_Id == item.Id);
                item.TypeOfSector = typessect;
            }
            sectorePageDTO.Sectors = sectors;
            sectorePageDTO.Cities = db.Cities.Select(a => new CityDto { Id = a.Id, Name = a.Name }).ToList();
            return sectorePageDTO;
        }

        // GET: api/Sectors/5
        [ResponseType(typeof(Sectors))]
        public IHttpActionResult GetSectors(int id)
        {
            Sectors sectors = db.Sectors.Find(id);
            if (sectors == null)
            {
                return NotFound();
            }
            sectors.TypeOfSector = db.TypeOfSector.Where(t => t.Sector_Id == sectors.Id).ToList();
            return Ok(sectors);
        }

        // PUT: api/Sectors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSectors(int id, Sectors sectors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sectors.Id)
            {
                return BadRequest();
            }

            db.Entry(sectors).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SectorsExists(id))
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

        // POST: api/Sectors
        [ResponseType(typeof(Sectors))]
        public IHttpActionResult PostSectors(Sectors sectors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Sectors.Add(sectors);
            db.SaveChanges();

            return Ok(sectors);
        }

        // DELETE: api/Sectors/5
        [ResponseType(typeof(Sectors))]
        public IHttpActionResult DeleteSectors(int id)
        {
            Sectors sectors = db.Sectors.Find(id);
            if (sectors == null)
            {
                return NotFound();
            }

            db.Sectors.Remove(sectors);
            db.SaveChanges();

            return Ok(sectors);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SectorsExists(int id)
        {
            return db.Sectors.Count(e => e.Id == id) > 0;
        }
    }
}