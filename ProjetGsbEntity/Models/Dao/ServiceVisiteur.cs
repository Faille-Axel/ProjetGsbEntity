using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetGsbEntity.Models.Dao
{
  
        public class ServiceVisiteur
        {
        private static ServiceVisiteur instance;
        private static Domain.AF_gsbccharpContext unService;
            /// <summary>
            /// Obtenir le singleton et le créer s'il n'existe pas
            /// </summary>
            public static ServiceVisiteur getInstance()
            {
                if (ServiceVisiteur.instance == null)
                {
                    ServiceVisiteur.instance = new ServiceVisiteur();
                    // on définit un contexte commun à toutes les requêtes
                    unService = new Domain.AF_gsbccharpContext();
                }
                return ServiceVisiteur.instance;
            }
            // Le constructeur devient privé
            private ServiceVisiteur()
            { }

            /// <summary>
            /// contrôle du login d'un visiteur
            /// </summary>
            /// <param name="numV"></param>
            /// <returns></returns>


            public Domain.Visiteur RechercheUnVisiteur(Int32 numV)
            {

            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur sur recherche d'un visiteur.", "RechercheUnVisiteur()");
                Domain.Visiteur unVisiteur;
                try
                {

                    unVisiteur = (from v in unService.Visiteur
                                  where v.IdVisiteur == numV
                                  select v).FirstOrDefault();
                    return unVisiteur;
                }
                catch (Exception e)
                {
                    throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
                }

            }

            /// <summary>
            /// Lister les Frais d'un visiteur
            /// </summary>
            /// <returns></returns>
            public List<Domain.Frais> ListedesFraisVisiteur(int id)
            {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur sur lecture des Frais.", "LectureFraisVisiteur");
                try
                {
                    var mesFrais = (from f in unService.Frais
                                    where f.IdVisiteur == id
                                    select f);
                    return mesFrais.ToList<Domain.Frais>();
                }
                catch (Exception e)
                {
                    throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
                }

            }
            /// <summary>
            /// On recherche les états
            /// </summary>
            /// <param name="id"></param>
            /// <returns></returns>

            public List<Domain.Etat> ListedesEtats()
            {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur sur lecture des états.", "LectureEtat");
                try
                {
                    var mesEtats = (from e in unService.Etat
                                    select e);
                    return mesEtats.ToList<Domain.Etat>();
                }
                catch (Exception e)
                {
                    throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
                }

            }

            /// <summary>
            /// Ajout d'un Frais
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public void AjouteFrais(Domain.Frais f)
            {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur  sur l'ajout d'un Frais.", "ajouteFrais");
                try
                {
                    unService.Frais.Add(f);
                }
                catch (Exception e)
                {
                    throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
                }

            }

            /// <summary>
            /// mise à jour
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public void MiseAjourDuModele()
            {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur  sur la mise à jour du modèle", "MiseAjourDuModele()");

                try
                {
                    unService.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new MesExceptions.MonException(er.MessageUtilisateur(), er.MessageApplication(), e.Message);
                }

            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="numV"></param>
            /// <returns></returns>
            public List<Domain.Visiteur> GetListeVisiteur()
            {

            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur liste des visiteurs.", "GetListeVisiteur()");

                try
                {
               var mesVisiteurs = (List<Domain.Visiteur>)(from v in unService.Visiteur            
                         select v).ToList();

                return mesVisiteurs;
                }
                catch (InvalidOperationException e)
                {
                    throw new MesExceptions.MonException(e.Message, "Liste des utilisateurs", "GetListeVisiteur");
                }

            catch (Exception e)
            {
                throw new MesExceptions.MonException(e.Message, "Liste des utilisateurs", "GetListeVisiteur");
            }

        }
        }
    }

