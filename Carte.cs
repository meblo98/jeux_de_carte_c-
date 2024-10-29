using System;

public enum Valeur
{
    As = 1,
    Deux = 2,
    Trois = 3,
    Quatre = 4,
    Cinq = 5,
    Six = 6,
    Sept = 7,
    Huit = 8,
    Neuf = 9,
    Dix = 10,
    Valet = 11,
    Dame = 12,
    Roi = 13
}

public enum Couleur
{
    Trefle,
    Carreau,
    Coeur,
    Pique
}

public struct Carte
{
    public Valeur Valeur { get; }
    public Couleur Couleur { get; }

    public Carte(Valeur valeur, Couleur couleur)
    {
        Valeur = valeur;
        Couleur = couleur;
    }

    public override string ToString()
    {
        return $"{Valeur} de {Couleur}";
    }
}
