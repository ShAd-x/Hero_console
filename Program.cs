using Exercice_3.Monstres;

namespace Exercice_3;

class Program {
    public static void Main(string[] args) {
        // Demander le nom du Héro
        Console.WriteLine("Quel est le nom de votre Héro ?");
        string name = Console.ReadLine() ?? string.Empty;
        
        // Création du Héro
        Hero hero = new Hero(name);
        int startHealth = hero.Health;

        // Variables de combat
        bool continuer = true;
        int round = 0;

        // Création du Monstre
        Monstre monstre = GestionnaireDePartie.SpawnMonstre();

        // Boucle de combat
        while (continuer) {
            Console.WriteLine($"\n========== DEBUT Round {round} ==========");
            // Log pour le récapitulatif du tour
            var heroVieDamageLog = hero.Health;
            var monstreVieDamageLog = monstre.Health;
            
            // Tour du Héro
            hero.Attaque(monstre);

            // Si le monstre meurt
            if (!monstre.Avenir()) {
                // Le héro vient de gagner le 5ème combat donc il se spécialise
                if (GestionnaireDePartie.NbMonstres == 6)
                {
                    GestionnaireDePartie.Specialisation(hero, startHealth);
                }
                // Le héro trouve un trésor
                hero.Tresor();
                
                // On fait réapparaître un nouveau monstre
                monstre = GestionnaireDePartie.SpawnMonstre();
                
                // Log pour le récapitulatif du tour
                monstreVieDamageLog = monstre.Health;
            } else {
                monstre.Attaque(hero);
            }
            
            // Si le héro meurt (passe à false)
            continuer = hero.Avenir();
            
            Console.WriteLine($"[Récapitulatif] {hero.Type} : {heroVieDamageLog} -> {hero.Health} = ({hero.Health - heroVieDamageLog})");
            Console.WriteLine($"[Récapitulatif] {monstre.Type} : {monstreVieDamageLog} -> {monstre.Health} = ({monstre.Health - monstreVieDamageLog})");
            Console.WriteLine($"========== FIN Round {round} ==========");
            
            // Si le héro n'est pas mort, on incrémente le round sinon on donne le récapitulatif
            if (continuer) {
                round++;
            } else {
                Recapitulatif(round, hero, GestionnaireDePartie.NbMonstres - 1, monstre);
            }
            Wait();
        }
    }
    
    /**
     * Met en pause le programme
     */
    private static void Wait()
    {
        Thread.Sleep(2000);
    }

    /**
     * Affiche le récapitulatif de la partie
     * 
     * @param round Le nombre de round final
     * @param hero Le héro
     * @param nbMonstres Le nombre de monstres tués
     * @param monstre Le dernier monstre en vie
     */
    private static void Recapitulatif(int round, Hero hero, int nbMonstre, Monstre monstre)
    {
        Console.WriteLine($"{hero.Type} {hero.Name} est mort au round {round}, et c'est le {monstre.Type} n°{nbMonstre} qui l'a tué.");
    }
}
