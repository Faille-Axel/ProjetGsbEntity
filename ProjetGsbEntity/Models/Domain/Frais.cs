using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Frais
    {
        public Frais()
        {
            Fraishorsforfait = new HashSet<Fraishorsforfait>();
            LigneFraisforfait = new HashSet<LigneFraisforfait>();
        }

        public int IdFrais { get; set; }
        public int IdEtat { get; set; }
        public string Anneemois { get; set; }
        public int IdVisiteur { get; set; }
        public int? Nbjustificatifs { get; set; }
        public DateTime? Datemodification { get; set; }
        public decimal? Montantvalide { get; set; }

        public virtual Etat IdEtatNavigation { get; set; }
        public virtual Visiteur IdVisiteurNavigation { get; set; }
        public virtual ICollection<Fraishorsforfait> Fraishorsforfait { get; set; }
        public virtual ICollection<LigneFraisforfait> LigneFraisforfait { get; set; }
    }
}
