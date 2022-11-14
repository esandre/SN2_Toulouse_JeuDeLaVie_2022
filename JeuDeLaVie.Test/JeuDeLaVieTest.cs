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
    }
}