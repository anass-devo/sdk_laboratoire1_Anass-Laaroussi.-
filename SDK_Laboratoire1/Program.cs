using System;
using System.Collections.Generic;
using System.Threading;
using LibrairieConversionNote;

namespace SDK_Laboratoire1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string lettre;
            string note;

            Console.CancelKeyPress += (sender, e) =>
            {

                Console.WriteLine("Vous avez quitté le programme.");
                Environment.Exit(0);

            };
            List<string> notesValides = new List<string> { "A", "B", "C", "D", "E", "F", "G" };
            while (true)
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
    }
}
