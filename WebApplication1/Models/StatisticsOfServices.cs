using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Statistics_Services")]
    public class StatisticsOfServices
    {
        public int Id { get; set; }
        public string Office_Name { get; set; }
        public string Service { get; set; }
        public string ServiceType { get; set; }
        public string Location { get; set; }
        public DateTime DateTime { get; set; }
        public int Rate { get; set; }
    }
}