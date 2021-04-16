using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smoothboard.Models
{
    public class Voorraad
    {
        [ForeignKey("Surfboard")]
        [Display(Name = "Surfboard")]
        public int SurfboardId { get; set; }

        public virtual Surfboards Surfboard { get; set; }

        [ForeignKey("filiaal")]
        [Display(Name = "filiaal")]
        public int FiliaalId { get; set; }

        public virtual Filiaal Filiaal { get; set; }

        public int Aantal { get; set; }
    }
}
