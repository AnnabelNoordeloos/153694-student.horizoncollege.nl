using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard.Models
{
    public class Gebruiker//: IdentityUser
    {
        public int Id { get; set; }
        public string Email { get; set; }

        public Boolean Nieuwsbrief { get; set; }
    }
}
