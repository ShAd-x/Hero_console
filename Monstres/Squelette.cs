namespace Exercice_3.Monstres;

public class Squelette : Monstre
{
    public Squelette(string name) : base(name, "Squelette")
    {
        // Santé
        Random y = new Random();
        Health = y.Next(60, 311);

        // Dégâts
        Random x = new Random();
        Damage = x.Next(10, 16);
        
        Caracteristiques();
    }
}