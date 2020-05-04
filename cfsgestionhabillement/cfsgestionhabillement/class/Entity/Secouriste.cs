using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfsgestionhabillement.Entity
{
    public class Secouriste
    {
        public Secouriste() { }
        public int ID_Secouriste { get; set; }
        public string Nom_Secouriste { get; set; }
        public string Prenom_Secouriste { get; set; }
        public string NumeroTel_Secouriste { get; set; }
        public string Adresse_Secouriste { get; set; }
        public string CodePostal_Secouriste { get; set; }
        public string Ville_Secouriste { get; set; }
        public DateTime DateNaissance_Secouriste { get; set; }
        public string Email_Secouriste { get; set; }
        public string Username_Secouriste { get; set; }
        public string Password_Secouriste { get; set; }
        public bool Cotisation_Secouriste { get; set; }
        public int ID_Fonction { get; set; }

    }
}
