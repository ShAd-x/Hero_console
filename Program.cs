using Exercice_3.Monstres;

namespace Exercice_3;

class Program {
    public static void Main(string[] args) {
        // Demander le nom du Héro
        Console.WriteLine("Quel est le nom de votre Héro ?");
        string name = Console.ReadLine() ?? string.Empty;
        
        // Création du Héro
        Hero hero = new Hero(name);

        // Variables de combat
        bool continuer = true;
        int round = 0, nbMonstre = 1;

        // Création du Monstre
        Gobelin monstre = new Gobelin(Convert.ToString(nbMonstre));

        // Boucle de combat
        while (continuer) {
            Console.WriteLine($"\n========== DEBUT Round {round} ==========");
            var heroVieDamageLog = hero.Health;
            var monstreVieDamageLog = monstre.Health;
            
            // Tour du Héro
            hero.Attaque(monstre);

            // Si le monstre meurt
            if (!monstre.Avenir()) {
                hero.Tresor();
                
                nbMonstre++;
                monstre = new Gobelin(Convert.ToString(nbMonstre));
                monstreVieDamageLog = monstre.Health;
            } else {
                monstre.Attaque(hero);
            }

            continuer = hero.Avenir();
            
            Console.WriteLine($"[Récapitulatif] Héro : {heroVieDamageLog} -> {hero.Health} = ({hero.Health - heroVieDamageLog})");
            Console.WriteLine($"[Récapitulatif] Monstre : {monstreVieDamageLog} -> {monstre.Health} = ({monstre.Health - monstreVieDamageLog})");
            Console.WriteLine($"========== FIN Round {round} ==========");
            if (continuer) {
                round++;
            } else {
                Recapitulatif(round, hero, nbMonstre);
            }
            Wait();
        }
    }
    
    private static void Wait()
    {
        Thread.Sleep(2000);
    }

    private static void Recapitulatif(int round, Hero hero, int nbMonstre)
    {
        Console.WriteLine($"{hero.Type} {hero.Name} est mort au round {round}, et c'est le monstre n°{nbMonstre} qui l'a tué.");
    }
}
