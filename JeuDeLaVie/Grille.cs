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
            if(!cellules[0].EstVivante)
                cellules[0].PasserUnTour();

            if (!cellules[1].EstVivante)
                cellules[1].PasserUnTour();
        }

        public void PasserUnTour()
        {
          
        }
    }
}
