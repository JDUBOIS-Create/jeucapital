using System;

class Program
{
    static void Main(string[] args)  // La méthode Main est le point d'entrée du programme
    {
        // Tableaux des pays et capitales
        string[] pays = { "Albanie", "Allemagne", "Andorre", "Autriche", "Belgique",
              "Biélorussie", "Bosnie-Herzégovine", "Bulgarie", "Chypre", "Croatie" };

        string[] capitales = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne",
                   "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie",  "Zagreb" };

        bool continuer = true;
        while (continuer)
        {
            int bonnesRep = 0;
            // Boucle sur les pays et capitales
            for (int i = 0; i < pays.Length; i++)  // Utilise l'index croissant pour l'itération
            {
                Console.WriteLine($"\nQuelle est la capitale du pays suivant : {pays[i]} ?");
                string? rep = Console.ReadLine();  // Lecture de la réponse

                // Vérifie si la réponse est correcte
                if (rep == capitales[i])
                {
                    bonnesRep++;
                    Console.WriteLine("Bravo !");
                }
                else
                {
                    Console.WriteLine($"Mauvaise réponse. La réponse était : {capitales[i]}");
                }
            }
            Console.WriteLine($"\n{bonnesRep} bonnes réponses sur {pays.Length}");

            // Demande si l'utilisateur veut rejouer
            Console.WriteLine("Voulez-vous rejouer (O/N) ?");
            string? rep2 = Console.ReadLine();
            if (rep2 == "O" || rep2 == "o")
                Console.Clear();  // Efface l'écran pour une nouvelle partie
            else
            {
                continuer = false;  // Termine la boucle si l'utilisateur ne veut plus jouer
                Console.WriteLine("Merci d'avoir joué !");
            }
        }
    }
}
