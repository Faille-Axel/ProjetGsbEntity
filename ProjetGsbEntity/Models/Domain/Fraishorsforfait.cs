using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Fraishorsforfait
    {
        public int IdFraishorsforfait { get; set; }
        public int IdFrais { get; set; }
        public DateTime? DateFraishorsforfait { get; set; }
        public decimal? MontantFraishorsforfait { get; set; }
        public string LibFraishorsforfait { get; set; }

        public virtual Frais IdFraisNavigation { get; set; }
    }
}
