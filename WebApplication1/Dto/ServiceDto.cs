using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Dto
{
    public class ServiceDto
    {
        public ServiceDto()
        {
                
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<TypeDto> Types { get; set; }
    }
}