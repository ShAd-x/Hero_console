namespace Exercice_3;

internal class Hero : Entitee
{

    public Hero()
    {
        //Création du Héro
        Type = "Héro";

        //Demander le nom du Héro
        Console.WriteLine("Quel est le nom de votre Héro ?");
        Name = Console.ReadLine() ?? string.Empty;

        //Vie du Héro
        Health = 200;

        //Dégât
        Random x = new Random();
        Damage = x.Next(15, 42);

        Console.WriteLine("[APPARITION] Un héro rentre en jeu !");
        Caracteristiques();
    }

    public void Tresor()
    {
        //Trésor
        Random x = new Random();
        var destin = x.Next(1, 2);

        Random y = new Random();
        var point = y.Next(1, 75);

        switch (destin)
        {
            case 1:
                Console.WriteLine("[TRESOR] Le héro " + Name + " a trouvé un trésor de " + point + " points de vie");
                //Modifier les points de vie
                Health += point;
                break;
            case 2:
                Console.WriteLine("[PIEGE] Le héro " + Name + " est tombé dans un piège et perd " + point + " points de vie");
                //Modifier les points de vie
                Health -= point;
                break;
        }
    }
}