using Exercice_3.Monstres;

namespace Exercice_3;

public class GestionnaireDePartie
{
    // Nombre de monstres créés et est aussi le nom du monstre
    public static int NbMonstres = 1;

    /**
     * Fait apparaître un monstre dans la partie
     * 
     * @return Monstre
     */
    public static Monstre SpawnMonstre()
    {
        var random = new Random();
        var nbMonstres = NbMonstres.ToString();
        
        // On incrémente le nombre de monstres
        NbMonstres++;

        return random.Next(1, 4) switch
        {
            1 => new Gobelin(nbMonstres),
            2 => new Squelette(nbMonstres),
            3 => new Sorciere(nbMonstres),
            _ => new Gobelin(nbMonstres)
        };
    }

    /**
     * Spécialisation du héro
     *
     * @param Hero hero
     * @param int startHealth
     */
    public static void Specialisation(Hero hero, int startHealth)
    {
        var random = new Random();
        switch (random.Next(1, 4))
        {
            case 1:
                hero.ChangeSpecialisation("Chevalier", startHealth * 0.2, hero.Damage * 0.10);
                break;
            case 2:
                hero.ChangeSpecialisation("Archer", startHealth * 0.15, hero.Damage * 0.15);
                break;
            case 3:
                hero.ChangeSpecialisation("Magicien", startHealth * 0.10, hero.Damage * 0.20);
                break;
        }
        Console.WriteLine($"Votre héro est devenu un {hero.Type} !");
    }
}