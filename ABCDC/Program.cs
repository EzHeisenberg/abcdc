using System;

namespace ABCDC
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";

            do
            {
                Console.Clear();

                Console.WriteLine("            _ __ ___   ___ _ __  _   _ ");
                Console.WriteLine("           | '_ ` _ \\ / _ \\ '_ \\| | | |");
                Console.WriteLine("           | | | | | |  __/ | | | |_| |");
                Console.WriteLine("           |_| |_| |_|\\___|_| |_|\\__,_|");

                Console.WriteLine("\n\nBienvenu:\n");
                Console.WriteLine("    1- Gestion des participants");
                Console.WriteLine("    2- Gestion des adéhrants");
                Console.WriteLine("    3- Créer des équipes pour le prochain match");
                Console.WriteLine("    4- Quitter");

                Console.Write("\nChoisir une option : ");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        //redirection
                        Console.Clear();

                        Console.WriteLine("\n\n     1- Ajouter un participant");
                        Console.WriteLine("     2- Supprimer un participant");
                        Console.WriteLine("     3- Voir la liste des participants");
                        Console.WriteLine("     4- Retour au menu");

                        Console.Write("\nChoisir une option : ");
                        switch (Console.ReadLine())
                        {
                            //Ajouter participants
                            case "1":
                                Console.Clear();

                                Console.WriteLine("\n\n     Pour l'ajout d'un nouveau participant,");
                                Console.WriteLine("     veuillez saisir les informations suivantes.");

                                Person p = new Person();

                                Console.Write("\n     Nom : ");
                                p.LastName = Console.ReadLine();

                                Console.Write("     Prenom : ");
                                p.FirstName = Console.ReadLine();

                                Console.Write("     Ancienneté : ");
                                p.BeginYear = Int32.Parse(Console.ReadLine());

                                Console.Write("     Poids : ");
                                p.Weight = Int32.Parse(Console.ReadLine());

                                Console.Write("     Armure : ");
                                p.Armor = Console.ReadLine();

                                Console.Write("     Arme : ");
                                p.Weapon = Console.ReadLine();

                                Console.Clear();
                                Console.WriteLine("\n\n     Votre nouveau participant:");
                                Console.WriteLine("\n     " + p.LastName + " " + p.FirstName);
                                Console.WriteLine("     " + p.Weight);
                                Console.WriteLine("     " + p.BeginYear);
                                Console.WriteLine("     " + p.Armor);
                                Console.WriteLine("     " + p.Weapon);

                                Console.Write("\n\n\nAppuyer sur <Enter> pour retourner au menu... ");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                                break;

                            //Suprimer particpant
                            case "2":

                                break;

                            //Voir liste particpants
                            case "3":

                                break;

                            default:

                                break;
                        }

                        break;

                    case "2":
                        //redirection
                        Console.Clear();

                        break;

                    case "3":
                        //redirection
                        Console.Clear();

                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }

            } while (option != "4");

            
        }
    }
}
