using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class ServiceViewModel
    {
        public int Id { get; set; }
        public Services Service { get; set; }
        public string Name { get; set; }
        public List<SelectListItem> Services { get; set; }
    }
}