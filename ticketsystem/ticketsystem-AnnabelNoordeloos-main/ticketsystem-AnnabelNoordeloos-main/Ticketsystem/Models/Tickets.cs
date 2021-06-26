using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ticketsystem.Models
{
    public class Tickets
    {
        public int Id { get; set; }

        [ForeignKey("AspNetUsers")]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }

        [ForeignKey("Applications")]
        [Display(Name = "Applicatie")]
        public int ApplicationId { get; set; }

        public virtual Applications Applications { get; set; }


        [ForeignKey("Progress")]
        [Display(Name = "Progress")]

        public int ProgressId { get; set; }

        public virtual Progress Progress { get; set; }

        public string Subject { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }
    }
}
