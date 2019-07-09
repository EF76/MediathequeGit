using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeGit
{
    /// <summary>Classe Livre</summary>
    class Livre
    {
        /// <summary>
        /// Référence du Livre de type string ,code mis en place par la mediatheque
        /// </summary>
        private string _refLivre;
        /// <summary>
        /// Titre du livre
        /// </summary>
        private string _titreLivre;
        /// <summary>
        /// Nom de l'auteur du Livre
        /// </summary>
        private string _nomAuteur;
        /// <summary>
        /// nombre de pages du livre ( entier)
        /// </summary>
        private int _nbPages;
        /// <summary>
        /// etat du livre D comme disponible ou E comme emprunté
        /// </summary>
        private string _etat;
        /// <summary>
        ///  Variable de classe gérant le nombre d'instances créées
        /// </summary>
        private static int _nbLivres = 0;
        /// <summary>
        /// Constructeur de la classe livre
        /// _refLivre,_titreLivre,_nomAuteur,_nbPages sont valorisés
        /// _etat est initialisé à D dans le code du constructeur
        /// </summary>
        /// <param name="refLivre">reférence du Livre , chaine</param>
        /// <param name="titre">titre du livre, chaine</param>
        /// <param name="auteur">nom de l auteur, chaine</param>
        /// <param name="nbrePages">nbre de pages du Livre (entier)</param>
        public Livre ( string refLivre,string titre, string auteur, int nbrePages)
        {
            _refLivre = refLivre;
            _titreLivre = titre;
            _nomAuteur = auteur;
            _nbPages = nbrePages;
            _etat = "D";
            _nbLivres++;
        }
        /// <summary>
        /// accesseur sur la référence du Livre
        /// </summary>
        /// <returns>retourne la référence du livre,chaine </returns>
        public string GetRefLivre()
        {
            return _refLivre;
        }
        /// <summary>
        /// accesseur sur le titre du livre
        /// </summary>
        /// <returns>retourne le titre du livre, chaine</returns>
        public string GetTitre()
        {
            return _titreLivre;
        }
        /// <summary>
        /// accesseur sur le nom de l'auteur du livre
        /// </summary>
        /// <returns>retourne le nom de l'auteur, chaine</returns>
        public string GetNomAuteur()
        {
            return _nomAuteur;
        }
        /// <summary>
        /// accesseur sur le nombres de pages du livres
        /// </summary>
        /// <returns>retourne le nombre de pages du livres (entier)</returns>
         public int GetNbPages()
        {
            return _nbPages;
        }
        /// <summary>
        /// accesseur sur la variable de classe qui donne le nombre de livres créés
        /// </summary>
        /// <returns>retourne le nombre de livre crée(entier)</returns>
         public static int GetNbLivres()
         {
             return _nbLivres;
         }
        /// <summary>
        /// procedure qui affiche le titre du livre, le nom de l'auteur et le nombres de pages du livre
        /// </summary>
         public void Afficher()
         {
             Console.WriteLine(" Titre du Livre " + _titreLivre);
             Console.WriteLine(" Nom de l'auteur " + _nomAuteur);
             Console.WriteLine(" Nb de pages " + _nbPages);
         }
        /// <summary>
        /// modificateur du nombre de pages du livres
        /// </summary>
        /// <param name="newNnPages">le nouveau nombre de pages du livres(entier)</param>
         public void setNdPages(int newNnPages)
         {
             _nbPages = newNnPages;
         }
        /// <summary>
        /// acesseur sur l'etat du Livre 
        /// </summary>
        /// <returns></returns>
         public string GetEtat()
         {
             return _etat;
         }
        /// <summary>
        /// modificateur de l'état d'un Livre
        /// </summary>
        /// <param name="nouvEtat"></param>
         public void setEtat(String nouvEtat)
         {
             _etat = nouvEtat;
         }
        /// <summary>
        /// fonction qui compare 2 livres sur les nombres de pages
        /// retourne la valeur 0 si les nombres de pages sont à égalité
        /// retourne la valeur 1 si le nombre de pages du livre implicite est supérieur au nombre de pages de livre passé en paramètre
         /// retourne la valeur -1 si le nombre de pages du livre implicite est inférieure au nombre de pages de livre passé en paramètre
        /// </summary>
        /// <param name="ouvrage">livre passé en paramètre</param>
        /// <returns>valeur de retour à 0,1 ou -1 </returns>
         public int Compare(Livre ouvrage)
         {
             int valeur = 0;
             if (_nbPages == ouvrage._nbPages)
                 valeur = 0;
             else
                 if (_nbPages > ouvrage._nbPages)
                     valeur = 1;
                 else
                     valeur = -1;
             return valeur;

         }
        /// <summary>
        /// fonction qui calcule le cout de publication du livre
        /// ce cout est egal au nombre de pages * 0,090 euros
        /// </summary>
        /// <returns>retourne un double qui est le cout de publication du livre</returns>
         private double cout_publication()
         {
             return _nbPages * 0.09;
            }
        /// <summary>
        /// procedure qui affiche le cout de publication du livre
        /// </summary>
         public void AfficheCout()
         {
             Console.WriteLine(_titreLivre + " coute " + cout_publication() + " Euros");
         }

    }
}
