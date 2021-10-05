using System;
using System.Collections.Generic;

namespace ABCDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Session s = new Session();
            s.Date = DateTime.Now;

            List<Person> persons = new List<Person>();

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

                    //Gestion participants
                    case "1":
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

                                persons.Add(p);

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
                                Console.Clear();
                                
                                if (persons.Count == 0)
                                {
                                    Console.WriteLine("\n\n     Aucun particpant enregistré");
                                } else
                                {
                                    Console.WriteLine("Voici tous les participants:");
                                    int i = 1;
                                    foreach (Person item in persons)
                                    {
                                        Console.WriteLine("\n     " + i + ") " + item.LastName + " " + item.FirstName);
                                        Console.WriteLine("-------------------------------");
                                        i++;
                                    }

                                    Console.Write("\n\n   Sélectionner le participant à supprimer: ");
                                    int a = Int32.Parse(Console.ReadLine());
                                    persons.Remove(persons[a - 1]);

                                    //après suppression, clear l'écran
                                    Console.Clear();

                                    //puis réaffiche les participants
                                    i = 1;
                                    foreach (Person item in persons)
                                    {
                                        Console.WriteLine("\n     " + i + ") " + item.LastName + " " + item.FirstName);
                                        Console.WriteLine("-------------------------------");
                                        i++;
                                    }
                                }

                                Console.Write("\n\n\nAppuyer sur <Enter> pour retourner au menu... ");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }

                                break;

                            //Voir liste particpants
                            case "3":
                                Console.Clear();
                                
                                if (persons.Count == 0)
                                {
                                    Console.WriteLine("\n\n     Aucun participant enregistré");
                                } else
                                {
                                    Console.WriteLine("Voici tous les participants:");

                                    foreach (Person item in persons)
                                    {
                                        Console.WriteLine("\n     " + item.LastName + " " + item.FirstName);
                                        Console.WriteLine("-------------------------------");
                                    }
                                }

                                Console.Write("\n\n\nAppuyer sur <Enter> pour retourner au menu... ");
                                while (Console.ReadKey().Key != ConsoleKey.Enter) { }


                                break;

                            default:

                                break;
                        }

                        break;


                    //Gestion adhérants
                    case "2":
                        Console.Clear();

                        break;


                    //Créer équipes
                    case "3":
                        Console.Clear();

                        break;


                    //Quitter console
                    default:
                        Environment.Exit(0);

                        break;
                }

            } while (option != "4");



        }
    }
}
