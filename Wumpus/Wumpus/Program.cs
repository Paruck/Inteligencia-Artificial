using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{

    class Program
    {
        static void Main(string[] args)
        {
            Maze Camino = new Maze();
            Camino.CreateMaze();
            Camino.printMap();

            Console.WriteLine("Hola mundo");
        }
    }
}
