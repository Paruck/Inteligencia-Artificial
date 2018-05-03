using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wumpus
{
    class Maze
    {
        public enum Tipos
        {
            Camino,
            Brisa,
            Hedor,
            Hoyo,
            HedorOro,
            Wumpus,
        }
        public List<List<Tipos>> Mapa;

        private Random rnd = new Random();

        public void CreateMaze()
        {
            Mapa = new List<List<Tipos>>();
            
            for (int i = 0; i < 4; i++) {
                List<Tipos> tempList = new List<Tipos>();
                for (int j = 0; j < 4; j++)
                {
                    int random = rnd.Next(0, 30);

                    if (random > 0 && random < 10)
                    {
                        tempList.Add(Tipos.Camino);
                    }
                    else if (random > 10 && random < 20)
                    {
                        tempList.Add(Tipos.Hoyo);
                    }
                    else
                    {
                        tempList.Add(0);
                    }
                }
                Mapa.Add(tempList);
            }
            Hole(Mapa);
            Wumpus(Mapa);
        }

        public void Hole(List<List<Tipos>> M)
        {
            int size = Mapa.Count;
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++)
                {
                    if (Mapa[i][j] == Tipos.Hoyo)
                    {
                        if (j + 1 < size)
                        {
                            M[i][j + 1] = Tipos.Brisa;
                        }
                        if (j - 1 >= 0)
                        {
                            M[i][j - 1] = Tipos.Brisa;
                        }
                        if (i + 1 < size)
                        {
                            M[i + 1][j] = Tipos.Brisa;
                        }
                        if (i - 1 >= 0)
                        {
                            M[i - 1][j] = Tipos.Brisa;
                        }
                    }
                }
            }
        }

        public void Wumpus(List<List<Tipos>> M)
        {
            int size = Mapa.Count;
            int i = rnd.Next(4);
            int j = rnd.Next(4);
            M[i][j] = Tipos.Wumpus;


            if (j + 1 < size)
            {
                M[i][j + 1] = Tipos.Hedor;
            }
            if (j - 1 >= 0)
            {
                M[i][j - 1] = Tipos.Hedor;
            }
            if (i + 1 < size)
            {
                M[i + 1][j] = Tipos.Hedor;
            }
            if (i - 1 >= 0)
            {
                M[i - 1][j] = Tipos.Hedor;
            }

        }

        public void printMap()
        {
            for (int i = 0; i < Mapa.Count; i++){
                for (int j = 0; j < Mapa.Count; ++j){
                    Console.Write("{0}", (int)Mapa[i][j] + "     ");
                }
                Console.Write("\n");
            }
        }
    }
}
