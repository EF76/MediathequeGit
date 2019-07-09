using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediathequeGit
{
    class Program
    {
        /// <summary>
        /// procedure Menu
        /// </summary>
        static void menu()
        {

            Console.WriteLine(" Gestion de la Mediatheque");
            Console.WriteLine("1 - Afficher les livres de la médiathèque");
            Console.WriteLine("2 - Ajouter un livre au catalogue de la médiathèque");
            Console.WriteLine("3 - Supprimer un livre du catalogue de la médiathèque");
            Console.WriteLine(" ");
            Console.WriteLine("4 - Ajouter un membre à la médiathèque");
            Console.WriteLine("5 - Supprimer un membre de la médiathèque");
            Console.WriteLine("6 - Afficher tous les membres de la médiathèque");
            Console.WriteLine(" ");
            Console.WriteLine("7 - Attribuer un emprunt de livre à un membre");
            Console.WriteLine("8 - Rendu de livre par un membre dela médiathèque");
            Console.WriteLine("9 - Afficher tous les emprunts en cours");
            Console.WriteLine("0 - Sortir");

        }
        static void Main(string[] args)
        {
            
                /* int newNombre = 0; int result;
                 Livre ouvrage1 = new Livre("INF12434","le C# facile", "Edith François", 234);
                 Livre ouvrage2 = new Livre ("INF345","SQL fingers in the nose ", "Michèle Liegeard",256);
                 Console.WriteLine("auteur du livre " + " " + ouvrage1.GetTitre() + ": " + ouvrage1.GetNomAuteur());
                 Console.WriteLine("auteur du livre " + "  " + ouvrage2.GetTitre() + ": " + ouvrage2.GetNomAuteur());
                 Console.WriteLine("--------------------------------------------------------");
                 ouvrage1.Afficher();
                 Console.WriteLine("nouveau nb de pages ?");
                 newNombre = Int32.Parse(Console.ReadLine());
                 ouvrage1.setNdPages(newNombre);
                 ouvrage1.Afficher();
                 result = ouvrage1.Compare(ouvrage2);
                 if (result == 0)
                     Console.WriteLine("les 2 livres ont le meme nombre de pages");
                 else
                     if (result == 1)
                         Console.WriteLine(ouvrage1.GetTitre() + "avec " + ouvrage1.GetNbPages() + " pages a plus de pages que " + ouvrage2.GetTitre() + "(" + ouvrage2.GetNbPages() + ")");
                     else
                         Console.WriteLine(ouvrage2.GetTitre() + "avec " + ouvrage2.GetNbPages() + " pages a plus de pages que " + ouvrage1.GetTitre() + "(" + ouvrage1.GetNbPages() + ")");
                 ouvrage1.AfficheCout();
                 ouvrage2.AfficheCout();

                 Console.WriteLine("Ce progamme a utilisé " + Livre.GetNbLivres() + " Livres");
                 Console.ReadLine();*/

                // mettre quelques livres dans la médiathèque
                Mediatheque CDI = new Mediatheque();
                Livre L1 = new Livre("5583-3", "Excel 2013 pour les Nuls", "Harvey Greg", 336);
                CDI.AjouterLivre(L1);
                Livre L2 = new Livre("5585-7", "PowerPoint 2013 pour les Nuls", "Lowe Doug", 328);
                CDI.AjouterLivre(L2);
                Livre L3 = new Livre("5584-0", "Word 2013 pour les Nuls", "Gookin Dan", 345);
                CDI.AjouterLivre(L3);
                Livre L4 = new Livre("5600-7", "Windows 8.1", "McFedries Paul", 471);
                CDI.AjouterLivre(L4);
                Livre L5 = new Livre("0277-4", "Le PC avec Windows 8.1", "Boudier-Ducloy Nicolas", 139);
                CDI.AjouterLivre(L5);
                Livre L6 = new Livre("7502-9", "Microsoft Office 2013", "Reynald goulet", 423);
                CDI.AjouterLivre(L6);
                Livre L7 = new Livre("5425-6", "Smartphones et tablettes Android", "Hart-Davis Guy", 473);
                CDI.AjouterLivre(L7);
                Livre L8 = new Livre("0210-1", "Réseau à domicile: guide complet", "Boudier-Ducloy Nicolas", 375);
                CDI.AjouterLivre(L8);
                Livre L9 = new Livre("0701-3", "Mon ami Google", "Perri Pascal", 174);
                CDI.AjouterLivre(L9);
                Livre L10 = new Livre("0011-4", "Hacking interdit", "Harvey Greg", 407);
                CDI.AjouterLivre(L10);

                Membre M1 = new Membre("1", "FRANCOIS", "Edith", "3 rue du Lycée", "76000", "ROUEN", "Adulte");
                CDI.AjouterMembre(M1);
                Membre M2 = new Membre("2", "FRANCOIS", "Isabelle", "3 rue du Lycée", "76000", "ROUEN", "Enfant");
                CDI.AjouterMembre(M2);
                Membre M3 = new Membre("3", "PELLETIER", "Isabelle", "332 av de L'eure", "27000", "EVREUX", "Adulte");
                CDI.AjouterMembre(M3);
                Membre M4 = new Membre("4", "CRESSENT", "Valérie", "9 bd de L'Yser", "76000", "Le HAVRE", "Adulte");
                CDI.AjouterMembre(M4);

                int choix;
                string nouvRef, nouvTitre, nouvAuteur, supRef, refLivreE;
                string codeM, nomM, prenomM, adresseM, cpM, villeM, statutM;
                int nouvNbPages;
                bool suppression, ajoutEmp;
                choix = -1;
                while (choix != 0)
                {
                    menu();
                    Console.WriteLine("Votre choix ? ");
                    choix = Int32.Parse(Console.ReadLine());
                    switch (choix)
                    {
                        case 1:
                            CDI.AfficherTousLesLivres();
                            Console.WriteLine(" Vous avez actuellement " + CDI.LesLivres.Count + " Livres");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Saisie d un nouveau Livre");
                            Console.WriteLine("Entrez la reference du livre sous la forme xxxx-x");
                            nouvRef = Console.ReadLine();
                            Console.WriteLine("Entrez le titre du livre");
                            nouvTitre = Console.ReadLine();
                            Console.WriteLine("Entrez le nom de l'auteur");
                            nouvAuteur = Console.ReadLine();
                            Console.WriteLine("Entrez le nombre de pages du livre");
                            nouvNbPages = Int32.Parse(Console.ReadLine());
                            Livre nouvLivre = new Livre(nouvRef, nouvTitre, nouvAuteur, nouvNbPages);
                            CDI.AjouterLivre(nouvLivre);
                            break;
                        case 3:
                            Console.WriteLine("Entrez la reference du livre à supprimer sous la forme xxxx-x");
                            supRef = Console.ReadLine();
                            suppression = CDI.SupprimerLivre(supRef);
                            if (suppression)
                                Console.WriteLine("le livre a ete supprimé");
                            else
                                Console.WriteLine("Impossible d effectuer la suppression");
                            break;
                        case 4:
                        Console.WriteLine(" A Faire");
                            break;
                        case 5:
                        Console.WriteLine(" A Faire");
                        break;
                        case 6:
                        Console.WriteLine(" A Faire");
                        Console.ReadLine();
                            break;
                    case 7:
                        Console.WriteLine(" A Faire");
                        break;
                        case 8:
                        Console.WriteLine(" A Faire");
                        break;
                        case 9:
                        Console.WriteLine(" A Faire");
                        break;

                    }
                }
                Console.WriteLine("Bye Bye!");
                Console.ReadLine();


            
        }
    }
}
