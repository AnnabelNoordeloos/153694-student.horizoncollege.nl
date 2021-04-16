using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Smoothboard.Models
{
    public class Surfboards
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public string Beschrijving { get; set; }

        [Column (TypeName = "decimal(18,2)")]
        public int Prijs { get; set; }

        [Display(Name = "Afbeelding")]
        public string FotoUrl { get; set; }

        [ForeignKey("Materiaal")]
        [Display(Name = "Materiaal")]
        public int MateriaalId { get; set; }

        public virtual Materiaal Materiaal { get; set; }


        public virtual ICollection<Voorraad> Voorraad { get; set; }
    };
}
