using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ticketsystem.Models
{
    public class AspNetUsers
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string NormalizedUserName { get; set; }

        public string Email { get; set; }

        public string NormalizedEmail { get; set; }

        public bool EmailConfirmed { get; set; }

        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set; }

        public int ConCurrencyStamp { get; set; }

        public int PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set;  }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Preposition { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public string LockOutEnd { get; set; }

        public bool LockOutEnabled { get; set; }

        public int AccessFailedCount { get; set; }
    }
}
