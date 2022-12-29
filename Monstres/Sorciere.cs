namespace Exercice_3.Monstres;

public class Sorciere : Monstre
{
    public Sorciere(string name) : base(name, "Sorcière")
    {
        // Santé
        Random y = new Random();
        Health = y.Next(20, 125);

        // Dégâts
        Random x = new Random();
        Damage = x.Next(55, 75);
        
        Caracteristiques();
    }
}