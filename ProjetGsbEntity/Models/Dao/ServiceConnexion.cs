using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetGsbEntity.Models.Dao
{
    public class ServiceConnexion
    {
        private static ServiceConnexion instance;
        private static Domain.AF_gsbccharpContext unService;
        private Domain.Visiteur unVisiteur;

        public Domain.Visiteur UnVisiteur { get => unVisiteur; set => unVisiteur = value; }

        /// <summary>
        /// Obtenir le singleton et le créer s'il n'existe pas
        /// </summary>
        public static ServiceConnexion getInstance()
        {
            if (ServiceConnexion.instance == null)
            {
                ServiceConnexion.instance = new ServiceConnexion();
                // on définit un contexte commun à toutes les requêtes
                unService = new Domain.AF_gsbccharpContext();
            }
            return ServiceConnexion.instance;
        }
        // Le constructeur devient privé
        private ServiceConnexion()
        { }

        public Domain.Visiteur RechercheUnVisiteur(String login)
        {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
            Domain.Visiteur unVisiteur;
            try
            {
                unVisiteur = (from v in unService.Visiteur
                              where v.LoginVisiteur == login
                              select v).FirstOrDefault();
                return unVisiteur;
            }
            catch (Exception e)
            {
                throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
            }
        }
    }
}
