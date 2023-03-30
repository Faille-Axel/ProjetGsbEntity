using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class StatsPrescriptions
    {
        public int IdPraticien { get; set; }
        public int IdMedicament { get; set; }
        public int AnneeMois { get; set; }
        public int? Quantite { get; set; }
    }
}
