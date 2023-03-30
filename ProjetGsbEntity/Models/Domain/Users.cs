using System;
using System.Collections.Generic;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PwdUser { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? UserUpdate { get; set; }
        public string Role { get; set; }
        public int IdVisiteur { get; set; }

        public virtual Visiteur IdVisiteurNavigation { get; set; }
    }
}
