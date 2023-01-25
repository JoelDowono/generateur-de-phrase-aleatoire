using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string ObtenirElementAleatoire(string[] t)
        {
            Random rand = new Random();
            int i = rand.Next(t.Length);
            return t[i];
        }

        static void Main(string[] args)
        {
            var sujets = new string[] {
                "Un lapin",
                "Une grand-mère",
                "Un chat",
                "Un bonhomme de neige",
                "Une limace",
                "Une fee",
                "Un magicien",
                "Une tortue",
            };

            var verbes = new string[] {
                "court",
                "parle",
                "aime",
                "joue",
                "écoute",
                "mange",
                "apprend",
                "voyage",
                "travail",
                "danse",
                "se bat avec",
                "s'acroche à",
            };

            var complements = new string[] {
                /*"un arbre",
                "un livre",
                "la lune",*/
                "le soleil",
               /* "un serpent",
                "une carte",
                "une girafe",*/
                "le ciel",
                /*"une piscine",
                "un gateau",
                "une souris",
                "un crapaud"*/
            };
            
            int NB_PHRASE = 10;

            for(int i = 0; i < NB_PHRASE; i++)
            {
                string sujet = ObtenirElementAleatoire(sujets);
                string verbe = ObtenirElementAleatoire(verbes);
                string complement = ObtenirElementAleatoire(complements);

                var phrase = sujet + " " + verbe + " " + complement;

                phrase = phrase.Replace("à le", "au");

                Console.WriteLine(phrase);
            }

        }
    }
}