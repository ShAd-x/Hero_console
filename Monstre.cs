namespace Exercice_3;

internal class Monstre : Entitee
{
    public Monstre(string name) : base(name)
    {
        //Création du Monstre
        Type = "Monstre";

        //Nom du Monstre
        Name = name;

        //Santé
        Random y = new Random();
        Health = y.Next(30, 250);

        //Dégât
        Random x = new Random();
        Damage = x.Next(10, 35);

        Console.WriteLine("[APPARITION] Un monstre rentre en jeu !");
        Caracteristiques();
    }

    public void Attaque(Entitee cible) {
        cible.Health -= Damage;

        //Dégâts infligés
        Console.WriteLine("[ATTAQUE] Le Monstre actuel inflige " + Damage + " points de dégâts au " + cible.Type);
    }
}