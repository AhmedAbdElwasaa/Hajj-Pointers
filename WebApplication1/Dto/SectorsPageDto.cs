using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Dto
{
    public class SectorsPageDto
    {
        public List<Sectors> Sectors = new List<Sectors>();
        public List<CityDto> Cities = new List<CityDto>();
    }
}