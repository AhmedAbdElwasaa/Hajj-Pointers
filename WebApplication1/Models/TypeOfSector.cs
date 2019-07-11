using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Type_Of_Sector")]
    public class TypeOfSector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ActualNumber { get; set; }
        [ForeignKey("Sector")]
        public int Sector_Id { get; set; }
        public Sectors Sector { get; set; }
    }
}