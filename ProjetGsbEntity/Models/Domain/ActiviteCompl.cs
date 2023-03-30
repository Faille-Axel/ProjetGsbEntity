using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class ActiviteCompl
    {
        public int IdActiviteCompl { get; set; }
        public DateTime? DateActivite { get; set; }
        public string LieuActivite { get; set; }
        public string ThemeActivite { get; set; }
        public string MotifActivite { get; set; }
    }
}
