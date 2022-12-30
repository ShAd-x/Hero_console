namespace Exercice_3.Monstres;

public class Sorciere : Monstre
{
    public Sorciere(string name) : base(name, "Sorcière")
    {
        // Santé
        Random y = new Random();
        Health = y.Next(25, 126);

        // Dégâts
        Random x = new Random();
        Damage = x.Next(50, 71);
        
        Caracteristiques();
    }
}