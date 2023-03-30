using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGsbEntity.MesExceptions
{
    public struct sErreurs
    {
        private String messageUtilisateur;
        private String messageApplication;

        public sErreurs(String mu, String ma)
        {
            this.messageUtilisateur = mu;
            this.messageApplication = ma;
        }
        public String MessageUtilisateur()
        {
            return (messageUtilisateur);
        }
        public String MessageApplication()
        {
            return (messageApplication);
        }
    }
}
