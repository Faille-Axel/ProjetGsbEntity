using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Prescrire
    {
        public int IdDosage { get; set; }
        public int IdMedicament { get; set; }
        public int IdTypeIndividu { get; set; }
        public string Posologie { get; set; }
    }
}
