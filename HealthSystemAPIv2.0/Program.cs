using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemAPIv2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Health System v2.0 -- Player Class Only");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();

            int health = 50;

            Player player; // declaration
            //player.ShowStats();
            player = new Player(); // initialization
            player.ShowStats();
            player.TakeDamage(50);
            player.ShowStats();
            player.Heal(5);
            player.ShowStats();

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }

        static void Test()
        {
            
        }
    }
}
