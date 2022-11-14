using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVie
{
    public class Cellule
    {
        public Cellule(bool vivante)
        {
            EstVivante = vivante;
        }

        public bool EstVivante { get; private set; }

        public void PasserUnTour()
        {
            EstVivante = !EstVivante;
            
        }
    }

}
