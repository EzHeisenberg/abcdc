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

            Console.WriteLine("\n\nChoisir une option:\n");
            Console.WriteLine("    1- Ajouter un nouveau participant");
            Console.WriteLine("    2- Ajouter un nouvel adéhrant");
            Console.WriteLine("    3- Créer des équipes pour le prochain match");
            Console.WriteLine("    4- Quitter");

            switch (Console.ReadLine())
            {
                case "1":
                    //redirection
                    break;

                case "2":
                    //redirection
                    break;

                case "3":
                    //redirection
                    break;

                default:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
