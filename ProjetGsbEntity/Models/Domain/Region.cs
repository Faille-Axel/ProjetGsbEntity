using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Region
    {
        public int IdRegion { get; set; }
        public int? IdSecteur { get; set; }
        public string NomRegion { get; set; }
    }
}
