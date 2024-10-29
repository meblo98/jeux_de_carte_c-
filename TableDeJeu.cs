using System;
using System.Collections.Generic;

public class TableDeJeu
{
    public Stack<Carte> PileDePioche { get; private set; }
    public Stack<Carte> PileDeDepot { get; private set; }

    public TableDeJeu(PaireDeCartes paireDeCartes)
    {
        PileDePioche = new Stack<Carte>(paireDeCartes.Cartes);
        PileDeDepot = new Stack<Carte>();
    }

    public Carte Piocher()
    {
        if (PileDePioche.Count == 0 && PileDeDepot.Count > 0)
        {
            RemelangerDepot();
        }

        return PileDePioche.Pop();
    }

    public void DeposerCarte(Carte carte)
    {
        PileDeDepot.Push(carte);
    }

    private void RemelangerDepot()
    {
        var cartes = new List<Carte>(PileDeDepot);
        PileDeDepot.Clear();
        Random random = new Random();
        for (int i = cartes.Count - 1; i >= 0; i--)
        {
            int j = random.Next(i + 1);
            PileDePioche.Push(cartes[j]);
            cartes.RemoveAt(j);
        }
    }

    public Carte DerniereCarteDeposee()
    {
        return PileDeDepot.Peek();
    }
}
