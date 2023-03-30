using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Laboratoire
    {
        public Laboratoire()
        {
            Visiteur = new HashSet<Visiteur>();
        }

        public int IdLaboratoire { get; set; }
        public string NomLaboratoire { get; set; }
        public string ChefVente { get; set; }

        public virtual ICollection<Visiteur> Visiteur { get; set; }
    }
}
