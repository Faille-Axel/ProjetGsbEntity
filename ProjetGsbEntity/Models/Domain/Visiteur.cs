using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Visiteur
    {
        public Visiteur()
        {
            Frais = new HashSet<Frais>();
            Users = new HashSet<Users>();
        }

        public int IdVisiteur { get; set; }
        public int? IdLaboratoire { get; set; }
        public int? IdSecteur { get; set; }
        public string NomVisiteur { get; set; }
        public string PrenomVisiteur { get; set; }
        public string AdresseVisiteur { get; set; }
        public string CpVisiteur { get; set; }
        public string VilleVisiteur { get; set; }
        public DateTime? DateEmbauche { get; set; }
        public string Email { get; set; }
        public string PwdVisiteur { get; set; }
        public string SelVisiteur { get; set; }
        public string TypeVisiteur { get; set; }
        public string LoginVisiteur { get; set; }

        public virtual Laboratoire IdLaboratoireNavigation { get; set; }
        public virtual ICollection<Frais> Frais { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
