using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class StatisticsOfSectors
    {
        public int Id { get; set; }
        public string Office_Name { get; set; }
        public string Sector { get; set; }
        public string SectorType { get; set; }
        public int TargetNumber { get; set; }
    }
}