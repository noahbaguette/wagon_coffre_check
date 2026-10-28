using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wagon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int j = 1;
                for ( j = 1; j <= 5; j++)
                {
                    Console.WriteLine("*////Nouveau check////");
                    Console.WriteLine("Dans le wagon " + i);
                    Console.WriteLine("Le Coffre " + j + " est correct");
                }
                j = j - 4;
            }
            Console.WriteLine("tout les wagons ont étais Check.");
        }
    }
}
