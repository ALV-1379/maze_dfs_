using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mazedfs
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("radif ra vared konid");
            int radif = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("soton ra vared konid");
            int soton = Convert.ToInt32(Console.ReadLine());

            int[,] maze = sakhtmaze(radif, soton);

            
            
            rahmaz_dfs test = new rahmaz_dfs(maze);


            if (test.hal())
            {
                Console.WriteLine("masir zir vojod darad:");
                test.print();
            }
            else
            {
                Console.WriteLine("masiri vojod nadarad.");
                test.print();
            }
            Console.ReadKey();
        }

        private static int[,] sakhtmaze(int x, int y)
        {
            int[,] maze = new int[x, y];
            Random divar = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    maze[i, j] = divar.Next(2); //ساخت ماز با اعداد رندوم 0 و 1
                    
                }
            }

            return maze;
        }


    }
}
