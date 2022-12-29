namespace Exercice_3.Monstres;

public class Gobelin : Monstre
{
    public Gobelin(string name) : base(name, "Gobelin")
    {
        // Santé
        Random y = new Random();
        Health = y.Next(15, 175);

        // Dégâts
        Random x = new Random();
        Damage = x.Next(20, 45);
        
        Caracteristiques();
    }
}