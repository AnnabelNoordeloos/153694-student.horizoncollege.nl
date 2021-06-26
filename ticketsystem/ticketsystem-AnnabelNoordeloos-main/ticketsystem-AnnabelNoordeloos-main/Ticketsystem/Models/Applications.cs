using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ticketsystem.Models
{
    public class Applications
    {
        public int Id {get;set;}

        public string Name { get; set; }

        [ForeignKey("AspNetUser")]
        [Display(Name = "Maintainer")]
        public int MaintainerId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
