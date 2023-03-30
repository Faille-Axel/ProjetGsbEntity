using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Posseder
    {
        public int IdPraticien { get; set; }
        public int IdSpecialite { get; set; }
        public string Diplome { get; set; }
        public decimal? CoefPrescription { get; set; }
    }
}
