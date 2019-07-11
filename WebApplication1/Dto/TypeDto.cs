using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Dto
{
    public class TypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FK_Service { get; set; }
    }
}