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
        }

        public void PasserUnTour()
        {
          
        }
    }
}
