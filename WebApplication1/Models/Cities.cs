using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("City")]
    public class Cities
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(max)")]
        public string Name { get; set; }
    }
}