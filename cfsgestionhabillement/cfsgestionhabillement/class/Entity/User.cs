using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cfsgestionhabillement.Entity
{
    class User
    {
        public User() { }
        public int ID_SECOURISTE { get; set; }
        public string NOM { get; set; }
        public string PRENOM { get; set; }
        public string ADRESSE { get; set; }
        public string CODE_POSTAL { get; set; }
        public string VILLE { get; set; }
        public string EMAIL { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public bool CAUTION { get; set; }
        public Fonction FONCTION { get; set; }

    }
}
