using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MediathequeGit
{
    /// <summary>
    /// Classe Membre
    /// </summary>
    class Membre
    {
        /// <summary>
        /// code du membre de la médiathèque (chaine)
        /// </summary>
        String _codeMembre;
        /// <summary>
        /// accesseur/modificateur sur le code du membre
        /// </summary>
        public String CodeMembre
        {
            get { return _codeMembre; }
            set { _codeMembre = value; }
        }
        /// <summary>
        /// Nom du membre de la médiathèque
        /// </summary>
        String _nomMembre;
        /// <summary>
        /// accesseur/modificateur sur le nom du membre
        /// </summary>
        public String NomMembre
        {
            get { return _nomMembre; }
            set { _nomMembre = value; }
        }
        /// <summary>
        /// prenom du membre de la médiathèque
        /// </summary>
        String _prenomMembre;
        /// <summary>
        /// accesseur/modificateur sur le prenom du membre
        /// </summary>
        public String PrenomMembre
        {
            get { return _prenomMembre; }
            set { _prenomMembre = value; }
        }
        /// <summary>
        /// adresse du Membre de la médiathèque
        /// </summary>
        String _adresseMembre;
        /// <summary>
        /// accesseur/modificateur sur l adresse du membre
        /// </summary>
        public String AdresseMembre
        {
            get { return _adresseMembre; }
            set { _adresseMembre = value; }
        }
        /// <summary>
        /// code postal du Membre de la médiatheque
        /// </summary>
        String _cpMembre;
        /// <summary>
        /// accesseur/modificateur sur le code postal du membre
        /// </summary>
        public String CpMembre
        {
            get { return _cpMembre; }
            set { _cpMembre = value; }
        }
        /// <summary>
        /// ville du membre de la médiathèque
        /// </summary>
        String _villeMembre;
        /// <summary>
        /// accesseur/modificateur sur la ville du membre
        /// </summary>
        public String VilleMembre
        {
            get { return _villeMembre; }
            set { _villeMembre = value; }
        }
        /// <summary>
        /// statut du membre de ma médiathèque ( Adulte ou Enfant)
        /// </summary>
        String _statutMembre;
        /// <summary>
        /// accesseur/modificateur sur le statut du membre
        /// </summary>
        public String StatutMembre
        {
            get { return _statutMembre; }
            set { _statutMembre = value; }
        }
        /// <summary>
        /// nbre maximum d'emprunts auquel le Membre a droit
        /// </summary>
        int _nbEmpruntsMaxi;
        /// <summary>
        /// accesseur/modificateur sur le nbr d'emprunts maximun du membre
        /// </summary>
        public int NbEmpruntsMaxi
        {
            get { return _nbEmpruntsMaxi; }
            set { _nbEmpruntsMaxi = value; }
        }
        /// <summary>
        /// Nombre d'emprunts en cours qui ne peut dépasser _nbEmpruntsMaxi
        /// </summary>
        int _nbEmpruntsEnCours;
        /// <summary>
        /// accesseur/modificateur sur le nbre d'emprunts en cours du membre
        /// </summary>
        public int NbEmpruntsEnCours
        {
            get { return _nbEmpruntsEnCours; }
            set { _nbEmpruntsEnCours = value; }
        }
        /// <summary>
        /// Constructeur de la classe Membre
        ///Le nombre maximum d'emprunts est valorisé dans le code du constructeur par affectation a 5 si le Membre est Adulte, à 3 s'il est Enfant
        /// Le nombre d'emprunts en cours est valorisé à 0 à la creation du Memebre
        /// </summary>
        /// <param name="codeM">code Membre ( Chaine)</param>
        /// <param name="nomM">nom Membre</param>
        /// <param name="prenomM">prenom Membre</param>
        /// <param name="adresseM">adresse Membre</param>
        /// <param name="cpM">code postal Membre (chaine)</param>
        /// <param name="villeM">ville Membre</param>
        /// <param name="statutM">statut Membre valeur Adulte ou Enfant</param>
        public Membre(string codeM,string nomM,string prenomM,string adresseM, string cpM,string villeM, string statutM)
        {
            _codeMembre = codeM;
            _nomMembre = nomM;
            _prenomMembre = prenomM;
            _adresseMembre = adresseM;
            _cpMembre = cpM;
            _villeMembre = villeM;
            _statutMembre = statutM;
            if (_statutMembre == "Adulte")
                _nbEmpruntsMaxi = 5;
            else
                _nbEmpruntsMaxi = 3;
            _nbEmpruntsEnCours = 0;
        }
        /// <summary>
        /// procedure d'affichage d'un Membre avec le nombre d emprunts en cours / Nb emprunts Maximun autorisés
        /// </summary>
        public void AfficherMembre()
        {
            Console.WriteLine(_codeMembre + ": " + _nomMembre + " " + _prenomMembre + " Emprunts en cours : " + _nbEmpruntsEnCours + "/" + NbEmpruntsMaxi);

        }
        /// <summary>
        /// procedure d'affichage des coordonnées postales d'un membre
        /// </summary>
        public void AfficherCoordMembre()
        {
            Console.WriteLine(_codeMembre + ": M " + _nomMembre + " " + _prenomMembre);
            Console.WriteLine(_adresseMembre);
            Console.WriteLine(_cpMembre + " " + _adresseMembre);
        }


        


    }
}
