namespace Exercice_3;

internal interface Actions
{
    /**
     * Fonction qui permet d'attaquer une Entitee
     * @param cible Entitee à attaquer
     */
    public void Attaque(Entitee cible);
    /**
     * Fonction qui permet de définir la survie ou non d'une entitée
     */
    public bool Avenir();
}