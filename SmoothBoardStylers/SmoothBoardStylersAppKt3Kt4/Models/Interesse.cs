using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace SmoothBoardStylersApp.Models
{
    public class Interesse
    {
        public int Id { get; set; }

        [ForeignKey("surfboard")]
        [Display(Name = "surfboard")]
        public int SurfboardId { get; set; }
        public Surfboard Surfboard { get; set; }

        [ForeignKey("contact")]
        [Display(Name = "contact")]
        public int ContactId { get; set; }
        public Contact Contact { get; set; }

        [DefaultValue(false)]

        public bool Behandeld { get; set; }
    }
}
