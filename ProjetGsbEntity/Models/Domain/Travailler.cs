using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Travailler
    {
        public int IdVisiteur { get; set; }
        public DateTime Jjmmaa { get; set; }
        public int IdRegion { get; set; }
        public string RoleVisiteur { get; set; }
    }
}
