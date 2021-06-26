using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Ticketsystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("AspNetUsers")]
        [Display(Name = "FirstName")]
        public int FirstName { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        [ForeignKey("AspNetUsers")]
        [Display(Name = "LastName")]
        public int LastName { get; set; }

        [ForeignKey("AspNetUsers")]
        [Display(Name = "PrePosition")]
        public int Preposition { get; set; }
    }
}
