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


        [Theory(DisplayName = "ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf une " +
                            "QUAND on passe un tour " +
                            "ALORS la cellule morte devient vivante")]
        [InlineData(1)]
        [InlineData(2)]
        public void Test3(int celluleInitialementMorte)
        {
            //ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf une
            var cellules = Enumerable
                .Range(1, 4)
                .ToDictionary(
                    numéro => numéro,
                    numéro => new Cellule(vivante: numéro != celluleInitialementMorte));

            var grille = new Grille(cellules.Values.ToArray());

            //QUAND on passe un tour
            grille.PasserUnTour();

            //ALORS la cellule morte devient vivante
            var celluleMorte = cellules[celluleInitialementMorte];
            Assert.True(celluleMorte.EstVivante);
        }

        
    }

}