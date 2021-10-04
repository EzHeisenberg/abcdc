using System;

namespace ABCDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("            _ __ ___   ___ _ __  _   _ ");
            Console.WriteLine("           | '_ ` _ \\ / _ \\ '_ \\| | | |");
            Console.WriteLine("           | | | | | |  __/ | | | |_| |");
            Console.WriteLine("           |_| |_| |_|\\___|_| |_|\\__,_|");

            Console.WriteLine("\n\nBienvenu:\n");
            Console.WriteLine("    1- Ajouter un nouveau participant");
            Console.WriteLine("    2- Ajouter un nouvel adéhrant");
            Console.WriteLine("    3- Créer des équipes pour le prochain match");
            Console.WriteLine("    4- Quitter");

            Console.Write("\nChoisir une option : ");
            switch (Console.ReadLine())
            {
                case "1":
                    //redirection
                    Console.Clear();

                    Console.WriteLine("\n\n     Pour l'ajout d'un nouveau participant,");
                    Console.WriteLine("     veuillez saisir les informations suivantes.");

                    Console.Write("\n     Nom : ");
                    Console.ReadLine();

                    Console.Write("     Prenom : ");
                    Console.ReadLine();

                    Console.Write("     Ancienneté : ");
                    Console.ReadLine();

                    Console.Write("     Armure : ");
                    Console.ReadLine();

                    Console.Write("     Arme : ");
                    Console.ReadLine();

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
        }
    }
}
