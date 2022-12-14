namespace Exercice_3;

class Program {
    public static void Main(string[] args) {
        //Création du Héro
        Hero hero = new Hero();

        //Variables de combat
        bool continuer = true;
        int round = 0, nbMonstre = 1;

        //Création du Monstre
        Monstre monstre = new Monstre(Convert.ToString(nbMonstre));

        //Boucle de combat
        while (continuer) {
            Console.WriteLine("\n========== DEBUT Round " + round + " ==========");
            var hero_vie_damage_log = hero.Health;
            var monstre_vie_damage_log = monstre.Health;
            
            //Tour du Héro
            hero.Attaque(monstre);

            //Si le monstre meurt
            if (!monstre.Avenir()) {
                hero.Tresor();
                
                nbMonstre++;
                monstre = new Monstre(Convert.ToString(nbMonstre));
                monstre_vie_damage_log = monstre.Health;
            } else {
                monstre.Attaque(hero);
            }

            continuer = hero.Avenir();

            Console.WriteLine(
                "[Récapitulatif] Héro : " + hero_vie_damage_log + " -> " + hero.Health 
                + " = " + (hero.Health - hero_vie_damage_log)
            );
            Console.WriteLine("" +
                "[Récapitulatif] Monstre : " + monstre_vie_damage_log + " -> " + monstre.Health
                + " = " + (monstre.Health - monstre_vie_damage_log)
            );
            Console.WriteLine("========== FIN Round " + round + " ==========");
            round++;
            wait();
        }
    }
    
    private static void wait()
    {
        Thread.Sleep(2000);
    }
}
