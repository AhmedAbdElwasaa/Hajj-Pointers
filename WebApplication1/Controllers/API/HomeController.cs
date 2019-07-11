using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Dto;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1.Controllers.API
{
    [Authorize]
    public class HomeController : ApiController
    {
        private readonly ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: api/Home
       
        public MainDto Get()
        {
            var cities = _context.Cities.Select(a=> new CityDto { Id = a.Id, Name = a.Name });
            var offices = _context.Offices.Select(a=> new OfficeDto { Id=a.Id,Rate=a.Rate ?? 5, Number=a.Number});
            var services = _context.Services.Select(a=>new ServiceDto {Id=a.Id,Name=a.Name,
                Types = _context.TypeOfService.Select(aa => new TypeDto { Id=aa.Id , Name=aa.Name,FK_Service=aa.Service.Id}).ToList()
            });
            
            MainDto homeVM = new MainDto
            { 
              Cities = cities,
              Offices = offices,
              Services = services
            };

           return homeVM;

        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {


        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
