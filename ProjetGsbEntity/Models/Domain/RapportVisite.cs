using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class RapportVisite
    {
        public int IdRapport { get; set; }
        public int? IdPraticien { get; set; }
        public int IdVisiteur { get; set; }
        public DateTime? DateRapport { get; set; }
        public string Bilan { get; set; }
        public string Motif { get; set; }
    }
}
