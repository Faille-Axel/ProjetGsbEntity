using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Praticien
    {

        public Praticien()
        {
            
        }

        public int IdPraticien { get; set; }
        public int? IdTypePraticien { get; set; }
        public string NomPraticien { get; set; }
        public string PrenomPraticien { get; set; }
        public string AdressePraticien { get; set; }
        public string CpPraticien { get; set; }
        public string VillePraticien { get; set; }
        public decimal? CoefNotoriete { get; set; }
    }
}
