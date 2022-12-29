namespace Exercice_3;

public abstract class Entitee : Actions
{
    public string Type { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    protected Entitee(string name)
    {
        Name = name;
    }

    /**
     * Méthode qui permet de faire attaquer une entitée
     * @param cible : l'entitée attaquée
     */
    public void Attaque(Entitee cible)
    {
        cible.Health -= Damage;

        // Dégâts infligés
        Console.WriteLine($"[ATTAQUE] {Type} {Name} a infligé {Damage} points de dégâts à {cible.Type} {cible.Name}");
    }

    /**
     * Affiche dans la console si l'entité est morte ou non et retourne un booléen en fonction
     * @return bool : true si l'entité est vivante, false sinon
     */
    public bool Avenir()
    {
        // SI HEALTH <= 0 mort sinon survit
        Console.WriteLine(Health <= 0 ? $"[MORT] Le {Type} {Name} est mort" : $"[SURVIT] Le {Type} {Name} survit");
        return Health > 0;
    }

    /**
     * Affiche les informations de l'entité
     * @return string
     */
    protected void Caracteristiques()
    {
        Console.WriteLine($"[SPEC] Le {Type} {Name} a {Health} points de vie et {Damage} points de dégâts");
    }
}