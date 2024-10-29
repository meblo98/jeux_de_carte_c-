using System;
using System.Collections.Generic;

public class PaireDeCartes
{
    public List<Carte> Cartes { get; }

    public PaireDeCartes()
    {
        Cartes = new List<Carte>();
        foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
        {
            foreach (Valeur valeur in Enum.GetValues(typeof(Valeur)))
            {
                Cartes.Add(new Carte(valeur, couleur));
            }
        }
    }

    public void Melanger()
    {
        Random random = new Random();
        for (int i = Cartes.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            Carte temp = Cartes[i];
            Cartes[i] = Cartes[j];
            Cartes[j] = temp;
        }
    }
}
