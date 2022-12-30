using Exercice_3.Monstres;

namespace Exercice_3;

public class GestionnaireDePartie
{
    // Nb de monstres créés et est aussi le nom du monstre
    public static int NbMonstres = 1;

    /**
     * Fait apparaître un monstre dans la partie
     * @return Monstre
     */
    public static Monstre SpawnMonstre()
    {
        // Gobelin, Squelette, Sorcière
        var random = new Random();
        var nbMonstres = NbMonstres.ToString();
        
        // On incrémente le nombre de monstres
        NbMonstres++;

        return random.Next(1, 3) switch
        {
            1 => new Gobelin(nbMonstres),
            2 => new Squelette(nbMonstres),
            3 => new Sorciere(nbMonstres),
            _ => new Gobelin(nbMonstres)
        };
    }

    /**
     * Spécialisation du héro
     */
    public static void Specialisation(Hero hero, int startHealth)
    {
        // Chevalier, Archer, Magicien
        var random = new Random();
        switch (random.Next(1, 4))
        {
            // Chevalier
            case 1:
                hero.Type = "Chevalier";
                hero.Health += (int)(startHealth * 0.2);
                hero.Damage += (int)(hero.Damage * 0.10);
                Console.WriteLine("Votre héro est devenu un Chevalier !");
                break;
            // Archer
            case 2:
                hero.Type = "Archer";
                hero.Health += (int)(startHealth * 0.15);
                hero.Damage += (int)(hero.Damage * 0.15);
                Console.WriteLine("Votre héro est devenu un Archer !");
                break;
            // Magicien
            case 3:
                hero.Type = "Magicien";
                hero.Health += (int)(startHealth * 0.10);
                hero.Damage += (int)(hero.Damage * 0.20);
                Console.WriteLine("Votre héro est devenu un Magicien !");
                break;
        }
    }
}