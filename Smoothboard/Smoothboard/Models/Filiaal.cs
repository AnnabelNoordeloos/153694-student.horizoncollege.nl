using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard.Models
{
    public class Filiaal
    {
        public int Id { get; set; }

        public string Naam { get; set; }

        public string Adres { get; set; }

        public string Woonplaats { get; set; }

        public virtual ICollection<Voorraad> Voorraad { get; set; }

    }
}
