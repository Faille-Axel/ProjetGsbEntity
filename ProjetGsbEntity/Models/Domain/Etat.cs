using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Etat
    {
        public Etat()
        {
            Frais = new HashSet<Frais>();
        }

        public int IdEtat { get; set; }
        public string LibEtat { get; set; }

        public virtual ICollection<Frais> Frais { get; set; }
    }
}
