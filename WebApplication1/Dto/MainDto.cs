using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Dto
{
    public class MainDto
    {
        public IQueryable<OfficeDto> Offices { get; set; }
        public IQueryable<ServiceDto> Services { get; set; }
        public IQueryable<CityDto> Cities{ get; set; }
    }
}