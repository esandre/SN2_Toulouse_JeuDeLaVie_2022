using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVie
{
    public class Grille
    {
       public Grille(Cellule[] cellules)
       {
            var nombreVivantes = cellules.Count(cellule => cellule.EstVivante);

            switch (nombreVivantes)
            {
                case 0:
                case 2:
                    return;
            }

            foreach (var cellule in cellules.Where(cellule=> cellule.EstMorte()))
            {
                cellule.PasserUnTour();
            }
       }

        public void PasserUnTour()
        {
          
        }
    }
}
