using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazedfs
{
    class rahmaz
    {
        private int[,] maze;
        private int radif;
        private int soton;
        
        public int s
        {
            get
            {
                return soton;
            }
            set
            {
                soton = value;
            }
        }
        public int r
        {
            get
            {
                return radif;
            }
            set
            {
                radif = value;
            }
        }

        public rahmaz() { }
        public rahmaz(int[,] Maze)
        {
            maze = Maze;
            radif = maze.GetLength(0);
            soton = maze.GetLength(1);
        }

        public bool hal()
        {
            return masir(0, 0);
        }

        private bool masir(int x, int y)
        {
            if (x < 0 || x >= radif || y < 0 || y >= soton || maze[x, y] == 0)
            {
                return false; // مشخص شدن دیوار
            }

            if (maze[x, y] == 2)
            {
                return false; // قبلا چک شده
            }

            if (x == radif - 1 && y == soton - 1)
            {
                maze[x, y] = 2; // پایان
                return true;
            }

            maze[x, y] = 2; // بخشی از مسیر

            if (masir(x - 1, y)) // حرکت بالا
                return true;
            if (masir(x, y + 1)) // حرکت راست
                return true;
            if (masir(x + 1, y)) // حرکت پایین
                return true;
            if (masir(x, y - 1)) // حرکت چپ
                return true;

            maze[x, y] = 1; // عقب نشینی
            return false;
        }

        public void print()
        {
            for (int i = 0; i < radif; i++)
            {
                for (int j = 0; j < soton; j++)
                {
                    Console.Write(maze[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
