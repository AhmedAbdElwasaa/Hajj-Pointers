using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("User_Rate")]
    public class UserRate
    {
        public int Id { get; set; }
        public ApplicationUser User_Id { get; set; }
        public Offices Office_Id { get; set; }
    }
}