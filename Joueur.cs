using System;
using System.Collections.Generic;

public interface IPersonne
{
    string Nom { get; }
    string Prenom { get; }
}

public class Joueur : IPersonne
{
    public string Nom { get; }
    public string Prenom { get; }
    public Guid Id { get; }
    public List<Carte> Main { get; }

    public Joueur(string prenom, string nom)
    {
        Prenom = prenom;
        Nom = nom;
        Id = Guid.NewGuid();
        Main = new List<Carte>();
    }

    public void AjouterCarte(Carte carte)
    {
        if (Main.Count < 8)
        {
            Main.Add(carte);
        }
    }

    public Carte JouerCarte(int index)
    {
        var carte = Main[index];
        Main.RemoveAt(index);
        return carte;
    }

    public bool ADesCartes()
    {
        return Main.Count > 0;
    }

    public override string ToString()
    {
        return $"{Prenom} {Nom} (ID: {Id})";
    }
}
