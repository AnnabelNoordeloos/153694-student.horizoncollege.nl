using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ticketsystem.Models
{
    public class AspNetUserRoles
    {
        [ForeignKey("AspNetUser")]
        [Display(Name = "User")]
        public int UserId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        [ForeignKey("AspNetRoles")]
        [Display(Name = "Role")]
        public int RoleId { get; set; }

        public virtual AspNetRoles AspNetRoles { get; set; }
    }
}
