using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Sector")]
    public class Sectors
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Name { get; set; }
        public IEnumerable<TypeOfSector> TypeOfSector { get; set; }
    }
}