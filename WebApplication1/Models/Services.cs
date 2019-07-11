using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Service")]
    public class Services
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(max)")]
        public string Name { get; set; }
        public ICollection<TypeOfService> TypeOfService { get; set; }

    }
}