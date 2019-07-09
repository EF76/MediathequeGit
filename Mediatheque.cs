using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeGit
{
    
    /// <summary>
    /// La classe Médiathèque
    /// </summary>
    class Mediatheque
    {
        /// <summary>
        /// Liste de livres contenus dans la médiathèque
        /// </summary>
        private List<Livre> lesLivres = new List<Livre>();
        /// <summary>
        /// accesseur/modificateur sur la liste de livres de la médiathèque
        /// </summary>
        internal List<Livre> LesLivres
        {
            get { return lesLivres; }
            set { lesLivres = value; }
        }
        /// <summary>
        /// Liste des membres adhérents à la médiathèque
        /// </summary>
        private List<Membre> lesMembres = new List<Membre>();
        /// <summary>
        /// accesseur/modificateur sur la liste des membres de la médiathèque
        /// </summary>
        internal List<Membre> LesMembres
        {
            get { return lesMembres; }
            set { lesMembres = value; }
        }
        /// <summary>
        /// liste d'Emprunts effectués par les membres de la médiathèque
        /// </summary>
        private List<Emprunt> lesEmprunts = new List<Emprunt>();
        /// <summary>
        /// accesseur/mutateurs sur la Liste d'Emprunts
        /// </summary>
        internal List<Emprunt> LesEmprunts
        {
            get { return lesEmprunts; }
            set { lesEmprunts = value; }
        }
      /// <summary>
      /// Constructeur par défaut de la médiathèque
      /// </summary>
        public Mediatheque()
        {
        }
        /// <summary>
        /// procedure qui ajoute un livre à la liste de Livres de la médiathèque
        /// </summary>
        /// <param name="L">un livre L a été construit au préalable et est passé en argument pour être ajouté</param>
       public void  AjouterLivre(Livre L)
        {
            lesLivres.Add(L);
        }
        /// <summary>
        /// Procedure qui affiche tous les livres de la médiathèque
        /// la reférence du livre, le titre, le nom de l auteur et le nombre de pages de chaque livre 
        /// </summary>
        public void AfficherTousLesLivres()
        {
            foreach (Livre li in lesLivres)
            {
                Console.WriteLine(li.GetRefLivre() + "\t" + li.GetTitre().PadRight(35) + "\t" + li.GetNomAuteur().PadRight(20) + "\t" + li.GetNbPages() + " p");
            }

        }
        /// <summary>
        /// fonction qui supprime un livre dont la référence est passée en parametre
        /// </summary>
        /// <param name="refLivre">chaine qui représente la reférence du Livre à supprimer</param>
        /// <returns>la valeur true est retournée si la suppression a été effectuée et false sinon, cas ou la référence n'est pas trouvée</returns>
        public bool SupprimerLivre(string refLivre)
        {
            bool suppossible=false;
            int i,pos;
            pos = -1;
            for (i = 0; i < lesLivres.Count; i++)
            {
                if (lesLivres[i].GetRefLivre() == refLivre)
                {
                    pos = i;
                    suppossible = true;
                }
            }

            if (suppossible)
                lesLivres.RemoveAt(pos);
            return suppossible;
        }

        /// <summary>
        /// procedure qui ajoute un membre  à la liste de membres de la médiathèque
        /// </summary>
        /// <param name="M">un membre M a été construit au préalable et est passé en argument pour être ajouté</param>
        public void AjouterMembre(Membre M)
        {
            lesMembres.Add(M);
        }
        public bool SupprimerMembre(String codeM)
        {
            bool suppossible = false;
            int i, pos;
            pos = -1;
            for (i = 0; i < lesMembres.Count; i++)
            {
                if (lesMembres[i].CodeMembre == codeM)
                {
                    if ( lesMembres[i].NbEmpruntsEnCours == 0)
                    {
                    pos = i;
                    suppossible = true;
                    }
                }
            }

            if (suppossible)
                lesMembres.RemoveAt(pos);
            return suppossible;
        }
        /// <summary>
        /// procedure qui affiche tous les membres avec leur nb d'emprunts en cours
        /// </summary>
        public void AfficherTousLesMembres()
        {
            foreach (Membre M in lesMembres)
                M.AfficherMembre();
        }

        /// <summary>
        /// fonction qui ajoute un emprunt pour un membre s'il na pas dépassé le nb maximun d'emprunts
        /// Le code etat du livre est passé à E
        /// Le nombre d'emprunt en cours du membre est incrementé de 1
        /// </summary>
        /// <param name="refLivreE">la reférence du livre à emprunter</param>
        /// <param name="codeM">le code du membre</param>
        /// <returns>retourne True si l'emprunt a ete effectué, false sinon</returns>
        public bool AjouterEmprunt(string refLivreE,string codeM)
        {
            bool ajoutPossible = false;
            int i, posLivre;
            posLivre= -1;
            // recherche de la position du Livre
                for (i = 0; i < lesLivres.Count; i++)
            {
                if (lesLivres[i].GetRefLivre() == refLivreE)
                {
                     posLivre = i;
                }
            }
            int j, pos;
            pos = -1;
            // recherche de la position du membre
            for (j = 0; j < lesMembres.Count; j++)
            {
                if (lesMembres[j].CodeMembre == codeM)
                {
                    if (lesMembres[j].NbEmpruntsEnCours < lesMembres[j].NbEmpruntsMaxi)
                    {
                        pos = j;
                        ajoutPossible = true;
                    }
                    else
                    {
                        lesMembres[j].AfficherMembre();
                        Console.WriteLine("vous etes au maximum ");
                    }
                }
            }
            if (ajoutPossible)
            {
                Emprunt E = new Emprunt(refLivreE, codeM);
                lesEmprunts.Add(E);
                lesMembres[pos].NbEmpruntsEnCours = lesMembres[pos].NbEmpruntsEnCours + 1;
                lesLivres[posLivre].setEtat("E");
            }
            return ajoutPossible;
        }
        /// <summary>
        /// Affiche tous les emprunts de la médiathèque
        /// </summary>
        public void AfficherTousLesEmprunts()
        {
            foreach (Emprunt E in LesEmprunts)
            { 
                E.AfficherEmprunt();
            }

        }
        /// <summary>
        /// Fonction qui supprime l'emprunt de la liste des emprunts de la mediatheuqe quand le membre vient rendre le Livre
        /// Le nombre d'emprunts en cours du membre est décrémenté
        /// le code etat du livre repasse à D comme Disponible
        /// Il y a vérification du dépassement de la date limite ou non, dans ce cas une pénalité est exigée de 0,5 euros par jour de retard
        /// </summary>
        /// <param name="refLivreE">reférence du livre qui est rendu</param>
        /// <param name="codeM">code du membre qui rapporte le livre</param>
        /// <returns>retourne True si la suppression a ete réalisée , false sinon</returns>
        public bool RendreEmprunt(string refLivreE, string codeM)
        {
            bool sup = false;
            int i, posLivre;
            double penalites;
            posLivre = -1;
            TimeSpan ts;
            Emprunt E = new Emprunt(refLivreE, codeM);
            if (lesEmprunts.Contains(E))
            {
                if (DateTime.Today > E.CalculDateLimite())
                {
                    ts = DateTime.Now - E.CalculDateLimite();
                    penalites = ts.Days * 0.5;
                    Console.WriteLine(" Merci de rendre le livre mais vous etes en retard de " + ts.Days + "jours");
                    Console.WriteLine(" Vous aurez un pénalité de 0,5 euros par jour de retard, soit  " + penalites + " euros");
                    
                }
                lesEmprunts.Remove(E);
                sup = true;
                // recherche de la position du Livre
                for (i = 0; i < lesLivres.Count; i++)
                {
                    if (lesLivres[i].GetRefLivre() == refLivreE)
                    {
                        posLivre = i;
                    }
                }
                lesLivres[posLivre].setEtat("D");
                int j, pos;
                pos = -1;
                // recherche de la position du membre
                for (j = 0; j < lesMembres.Count; j++)
                {
                    if (lesMembres[j].CodeMembre == codeM)
                    {
                        lesMembres[j].NbEmpruntsEnCours = lesMembres[j].NbEmpruntsEnCours - 1;
                         pos = j;

                    }
                }

            }
            else
            {
                Console.WriteLine(" cet emprunt n 'est pas présent");
                    sup =false;
            }
                
            return sup;
            }
    }
}
