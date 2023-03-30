using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Fraisforfait
    {
        public Fraisforfait()
        {
            LigneFraisforfait = new HashSet<LigneFraisforfait>();
        }

        public int IdFraisforfait { get; set; }
        public string LibFraisforfait { get; set; }
        public decimal? MontantFraisForfait { get; set; }

        public virtual ICollection<LigneFraisforfait> LigneFraisforfait { get; set; }
    }
}
