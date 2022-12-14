namespace Exercice_3;

internal abstract class Entitee : Actions
{
    public string Type { get; set; }
    protected string Name { get; set; }
    public int Health { get; set; }
    protected int Damage { get; set; }

    protected Entitee() {}

    protected Entitee(string name)
    {
        Name = name;
    }

    protected Entitee(string type, string? name, int health, int damage)
    {
        Type = type;
        Name = name;
        Health = health;
        Damage = damage;
    }

    public void Attaque(Entitee cible)
    {
        cible.Health -= Damage;

        //Dégâts infligés
        Console.WriteLine("[ATTAQUE] " + Name + " a infligé " + Damage + " points de dégâts à " + cible.Type + " " + cible.Name);
    }

    public bool Avenir()
    {
        //SI HEALTH <= 0 mort sinon survit
        if (Health <= 0) {
            Console.WriteLine("[MORT] Le " + Type + " " + Name + " est mort");
        } else {
            Console.WriteLine("[SURVIT] Le " + Type + " " + Name + " survit");
        }
        return Health > 0;
    }

    protected void Caracteristiques()
    {
        Console.WriteLine(
            "[SPEC] Le "
            + Type + " "
            + Name + " a "
            + Health + " points de vie et "
            + Damage + " points de dégâts"
        );
    }
}