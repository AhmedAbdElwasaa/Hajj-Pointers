using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Office")]
    public class Offices
    {
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(max)")]
        public string Name { get; set; }
        [Column(TypeName ="nvarchar(max)")]
        public string Number { get; set; }
        public double? Rate { get; set; }
        public List<UserRate> User_Rate { get; set; }
    }
}