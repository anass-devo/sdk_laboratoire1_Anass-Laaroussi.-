using System;
using System.Collections.Generic;
using System.Threading;
using LibrairieConversionNote;

namespace SDK_Laboratoire1
{
    public class Program
    {
        public static void Main(string[] args)  // fonction principale de programme
        {
            string lettre;
            string note;

            Console.CancelKeyPress += (sender, e) =>  // fermiture du programme
            {

                Console.WriteLine("Vous avez quitté le programme."); 
                Environment.Exit(0);

            };
            List<string> notesValides = new List<string> { "A", "B", "C", "D", "E", "F", "G" }; // liste des valeur pou rle controle de saisie
            while (true)
            { // controle de choix de type de conversion .
                Console.WriteLine("Quel type de conversion souhaitez-vous faire ?");
                Console.WriteLine("1. Convertir de l'alphabet à la note");
                Console.WriteLine("2. Convertir de la note à l'alphabet");
                Console.WriteLine("Appuyez sur Ctrl+C pour quitter.");

                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    while (true)  // execution mode 1 
                    {
                        Console.WriteLine("Entrez une lettre alphabétique (A, B, C, D, E, F, G) Pour quitter appuyer sur Ctrl+c :");
                        lettre = Console.ReadLine();
                        lettre = lettre.ToUpper();

                        if (string.IsNullOrEmpty(lettre))
                            continue;

                        note = ConversionAlphabetiqueToNote.Transformer(lettre);
                        if (!notesValides.Contains(lettre))
                        {
                            Console.WriteLine("La note n'existe pas.");
                            continue;
                        }

                        Console.WriteLine($"La note qui correspond a la Lettre ' {lettre} ' est : {note} ");
                    }
                }
                else if (choix == "2")
                {
                    // fonction pas demander pour ce lab1
                    Console.WriteLine("Ce mode sera disponible bientot !!!!!!!!");
                    continue;
                }
                else
                {
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                }
            }
           

        }
    }
}
