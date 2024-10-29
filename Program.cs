using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Initialisation des joueurs
        var joueurs = new List<Joueur>
        {
            new Joueur("Mouhamed", "Lo"),
            new Joueur("Adama", "Dabo"),
            new Joueur("Seynabou", "Diop")
        };

        // Initialisation du jeu
        var jeuDePeche = new JeuxDePeche(joueurs);

        // Lancer la partie
        await jeuDePeche.DemarrerPartie();
    }
}
