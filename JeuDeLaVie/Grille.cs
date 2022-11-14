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
          
            foreach (var cellule in cellules.Where(cellule=>!cellule.EstVivante))
            {
                cellule.PasserUnTour();
            }
        }

        public void PasserUnTour()
        {
          
        }
    }
}
