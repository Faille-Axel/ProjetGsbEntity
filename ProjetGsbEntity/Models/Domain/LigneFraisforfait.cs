using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class LigneFraisforfait
    {
        public int IdFrais { get; set; }
        public int IdFraisforfait { get; set; }
        public int? QuantiteLigne { get; set; }

        public virtual Frais IdFraisNavigation { get; set; }
        public virtual Fraisforfait IdFraisforfaitNavigation { get; set; }
    }
}
