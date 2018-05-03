using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Agente
    {
        private int x, y;
        public int getX() { return x; }
        public int getY() { return y; }
   
        public bool Arriba(int i, int j) { return true;}
        public bool Abajo(int i, int j) { return true; }
        public bool Derecha(int i, int j) { return true; }
        public bool Izquierda(int i, int j) { return true; }

        Agente(int i, int j)
        {
            x = i;
            y = j;  
        }

    }
}
