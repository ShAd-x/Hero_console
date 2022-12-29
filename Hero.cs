namespace Exercice_3;

internal class Hero : Entitee
{
    public Hero(string name) : base(name)
    {
        // Création du Héro
        Type = "Héro";

        // Vie du Héro
        Health = 200;

        // Dégâts
        Random x = new Random();
        Damage = x.Next(15, 42);

        Console.WriteLine("[APPARITION] Un héro rentre en jeu !");
        Caracteristiques();
    }

    /**
     * Lors de la victoire du Héro sur un monstre il gagne un trésor qui soit
     * lui donne des points de vie ou des points de dégâts
     */
    public void Tresor()
    {
        // Trésor 50 / 50
        Random x = new Random();
        var destin = x.Next(1, 2);

        // Point de vie à ajouter ou à retirer selon le destin
        Random y = new Random();
        var point = y.Next(1, 75);

        if (destin == 1)
        {
            Console.WriteLine($"[TRESOR] Le héro {Name} a trouvé un trésor de {point} points de vie");
            Health += point;
        }
        else
        {
            Console.WriteLine($"[PIEGE] Le héro {Name} est tombé dans un piège et perd {point} points de vie");
            Health -= point;
        }
    }
}