namespace JeuDeLaVie.Test
{
    public class JeuDeLaVieTest
    {
        [Fact(DisplayName = "ETANT DONNE une cellule vivante " +
              "QUAND on passe un tour " +
              "ALORS elle est morte")]
        public void Test1()
        {
            // ETANT DONNE une cellule vivante
            var cellule = new Cellule(vivante: true);

            // QUAND on passe un tour
            cellule.PasserUnTour();

            // ALORS elle est morte
            Assert.False(cellule.EstVivante);
        }

        [Fact(DisplayName = "ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes " +
                            "QUAND on passe un tour " +
                            "ALORS elles restent vivantes")]
        public void Test2()
        {
            //ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes
            var cellules = Enumerable
                .Range(default, 4)
                .Select(_ => new Cellule(vivante: true))
                .ToArray();

            var grille = new Grille(cellules);
            //QUAND on passe un tour
            grille.PasserUnTour();
            //ALORS elles restent vivantes
            Assert.True(cellules.All(cellule => cellule.EstVivante));
        }

    }

}