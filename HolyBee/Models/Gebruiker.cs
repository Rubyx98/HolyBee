using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolyBee.Models
{
    public class Gebruiker
    {
        public int GebruikerID { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Wachtwoord { get; set; }
        public string Email { get; set; }
        public int TelefoonNummer { get; set; }
    }
}