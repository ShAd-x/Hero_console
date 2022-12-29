namespace Exercice_3.Monstres;

public class Squelette : Monstre
{
    public Squelette(string name) : base(name, "Squelette")
    {
        // Santé
        Random y = new Random();
        Health = y.Next(65, 325);

        // Dégâts
        Random x = new Random();
        Damage = x.Next(10, 15);
        
        Caracteristiques();
    }
}