namespace JeuDeLaVie
{
    internal static class CelluleExtensions
    {
        public static bool EstMorte(this Cellule cellule) 
            => !cellule.EstVivante;
    }
}
