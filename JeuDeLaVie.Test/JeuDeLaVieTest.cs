using JeuDeLaVie.Test.Utilities;

namespace JeuDeLaVie.Test
{
    public class JeuDeLaVieTest
    {
        [Fact(DisplayName = "ETANT DONNE une cellule vivante " +
              "QUAND on passe un tour " +
              "ALORS elle est morte")]
        public void CelluleUnique()
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
            var cellules = new CelluleGenerator()
                .ToutesVivantes()
                .Generate(4)
                .ToArray();

            var grille = new Grille(cellules);

            //QUAND on passe un tour
            grille.PasserUnTour();

            //ALORS elles restent vivantes
            Assert.True(cellules.All(cellule => cellule.EstVivante));
        }

        [Fact(DisplayName = "ETANT DONNE une grille de 3x3 où toutes les cellules sont vivantes " +
                            "QUAND on passe un tour " +
                            "ALORS seules les cellules des coins sont vivantes")]
        public void Test3Par3()
        {
            //ETANT DONNE une grille de 3x3 où toutes les cellules sont vivantes
            var cellules = new CelluleGenerator()
                .ToutesVivantes()
                .Generate(9)
                .ToArray();

            var grille = new Grille(cellules);

            //QUAND on passe un tour
            grille.PasserUnTour();

            //ALORS elles restent vivantes
            Assert.True(cellules[0].EstVivante);
            Assert.False(cellules[1].EstVivante);
            Assert.True(cellules[2].EstVivante);
            Assert.False(cellules[3].EstVivante);
            Assert.False(cellules[4].EstVivante);
            Assert.False(cellules[5].EstVivante);
            Assert.True(cellules[6].EstVivante);
            Assert.False(cellules[7].EstVivante);
            Assert.True(cellules[8].EstVivante);
        }

        [Theory(DisplayName = "ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf une " +
                              "QUAND on passe un tour " +
                              "ALORS la cellule morte devient vivante")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]

        public void Test3(int celluleInitialementMorte)
        {
            //ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf une
            var cellules = new CelluleGenerator()
                .ToutesVivantes()
                .Sauf(celluleInitialementMorte)
                .Generate(4)
                .ToArray();

            var grille = new Grille(cellules);

            //QUAND on passe un tour
            grille.PasserUnTour();

            //ALORS la cellule morte devient vivante
            var celluleMorte = cellules[celluleInitialementMorte - 1];
            Assert.True(celluleMorte.EstVivante);
        }

        [Fact(DisplayName = "ETANT DONNE une grille de 2x2 où toutes les cellules sont mortes " +
                            "QUAND on passe un tour " +
                            "ALORS elles restent mortes")]
        public void Test4()
        {
            //ETANT DONNE une grille de 2x2 où toutes les cellules sont mortes
            var cellules = new CelluleGenerator()
                .ToutesMortes()
                .Generate(4)
                .ToArray();

            var grille = new Grille(cellules);
            //QUAND on passe un tour
            grille.PasserUnTour();
            //ALORS elles restent mortes
            Assert.True(cellules.All(cellule =>!cellule.EstVivante));
        }

        [Fact(DisplayName = "ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf deux " +
                              "QUAND on passe un tour " +
                              "ALORS aucune cellule change d'état")]
        public void Test5()
        {
            //ETANT DONNE une grille de 2x2 où toutes les cellules sont vivantes sauf deux
            var cellules = new CelluleGenerator()
                .ToutesVivantes()
                .Sauf(indice => indice <= 1)
                .Generate(4)
                .ToArray();
            
            var grille = new Grille(cellules);

            //QUAND on passe un tour
            grille.PasserUnTour();

            //ALORS aucune cellule change d'état
            Assert.False(cellules[0].EstVivante);
            Assert.False(cellules[1].EstVivante);
            Assert.True(cellules[2].EstVivante);
            Assert.True(cellules[3].EstVivante);
        }
    }
}