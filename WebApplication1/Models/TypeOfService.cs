using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Type_Of_Service")]
    public class TypeOfService
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(max)")]
        public string Name { get; set; }
        public Services Service { get; set; }
    }
}