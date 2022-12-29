namespace Exercice_3.Monstres;

public abstract class Monstre : Entitee
{
    public Monstre(string name, string type) : base(name)
    {
        // Type de monstre
        Type = type;
        
        Console.WriteLine($"[APPARITION] Un {type} entre en jeu !");
    }
}