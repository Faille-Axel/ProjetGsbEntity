using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Medicament
    {
        public int IdMedicament { get; set; }
        public int? IdFamille { get; set; }
        public string DepotLegal { get; set; }
        public string NomCommercial { get; set; }
        public string Effets { get; set; }
        public string ContreIndication { get; set; }
        public decimal? PrixEchantillon { get; set; }
    }
}
