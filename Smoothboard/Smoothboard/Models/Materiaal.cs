using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smoothboard.Models
{
    public class Materiaal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Surfboards> Surfboards { get; set; }
    }
}
