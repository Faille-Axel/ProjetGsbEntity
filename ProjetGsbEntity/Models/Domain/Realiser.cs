using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Realiser
    {
        public int IdActiviteCompl { get; set; }
        public int IdVisiteur { get; set; }
        public decimal? MontantAc { get; set; }
    }
}
