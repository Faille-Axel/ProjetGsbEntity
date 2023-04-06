using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms.Design;

namespace ProjetGsbEntity.Models.Dao
{
    public class ServicePraticien
    {
        private static ServicePraticien instance;
        private static Domain.AF_gsbccharpContext unService;

        public static ServicePraticien getInstance()
        {
            if (ServicePraticien.instance == null)
            {
                ServicePraticien.instance = new ServicePraticien();
                // on définit un contexte commun à toutes les requêtes
                unService = new Domain.AF_gsbccharpContext();
            }
            return ServicePraticien.instance;
        }
        // Le constructeur devient privé
        private ServicePraticien()
        { }

        /// <summary>
        /// Lister les praticiens
        /// </summary>
        /// <returns></returns>
        /// <exception cref="MesExceptions.MonException"></exception>
        public List<Domain.Praticien> GetListeDesPraticiens()
        {
            MesExceptions.sErreurs er = new MesExceptions.sErreurs("Erreur sur lecture des Praticiens.", "LectureDesPraticiens");
            try
            {

                var mesPraticiens = (List<Domain.Praticien>)(from p in unService.Praticien 
                    select p).ToList();

                return mesPraticiens;
            }
            catch (InvalidOperationException e)
            {
                throw new MesExceptions.MonException(e.Message, "Liste des utilisateurs", "GetListePraticien");
            }

            catch (Exception e)
            {
                throw new MesExceptions.MonException(e.Message, "Liste des utilisateurs", "GetListePraticien");
            }


        }
    }
}
