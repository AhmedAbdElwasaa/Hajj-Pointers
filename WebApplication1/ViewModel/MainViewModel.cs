using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.ViewModel
{
    public class MainViewModel
    {
        public Offices Office { get;  set;}
        public Services Service
        {
            get;
            set;   
        }
        public Cities City {
            get;
            set;
        }

        public List<SelectListItem> Offices { get; set; }
        public List<SelectListItem> Services { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}