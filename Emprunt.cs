using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeGit
{
    /// <summary>
    /// Classe Emprunt
    /// </summary>
    class Emprunt
    {
        /// <summary>
        /// ref du livre emprunté (chaine)
        /// </summary>
        private string _refLivreEmp;
        /// <summary>
        /// accesseur/modificateur sur la ref du Livre Emprunté
        /// </summary>
        public string RefLivreEmp
        {
            get { return _refLivreEmp; }
            set { _refLivreEmp = value; }
        }
        /// <summary>
        /// code de Membre qui fait l'emprunt (chaine)
        /// </summary>
        private string _codeMembreEmp;
        /// <summary>
        /// accesseur/mutateur sur le code de l'emprunteur
        /// </summary>
        public string CodeMembreEmp
        {
            get { return _codeMembreEmp; }
            set { _codeMembreEmp = value; }
        }
        /// <summary>
        /// Date de l'emprunt (DateTime) ( on recupera la date du système)
        /// </summary>
        private DateTime _dateEmprunt;
        /// <summary>
        /// accesseur/mutateur dur la date de l'emprunt
        /// </summary>
        public DateTime DateEmprunt
        {
            get { return _dateEmprunt; }
            set { _dateEmprunt = value; }
        }
        /// <summary>
        /// Contructeur d ela classe Emprunt
        /// </summary>
        /// <param name="refLivreE">ref du livre emprunté</param>
        /// <param name="codeMembreE">code de l'emprunteur</param>
        public Emprunt(string refLivreE, string codeMembreE )
        {
            _refLivreEmp = refLivreE;
            _codeMembreEmp = codeMembreE;
           _dateEmprunt = DateTime.Today;
        }
        /// <summary>
        /// fonction qui retourne la date limite de retour du livre emprunté
        /// il s'agit de la date d'emprunt + 15j
        /// </summary>
        /// <returns>Date limite du retour du Livre ( DateTime)</returns>
        public DateTime CalculDateLimite()
        {
            return _dateEmprunt.AddDays(15);
        }
        /// <summary>
        /// procedure qui affiche la ref du Livre, le code emprunteur, la date d'emprunt, la date Limite de retour
        /// </summary>
        public void AfficherEmprunt()
        {
            Console.WriteLine(_refLivreEmp + " " + _codeMembreEmp + " " + _dateEmprunt.ToShortDateString() + " " + CalculDateLimite().ToShortDateString());
        }

    }
}
