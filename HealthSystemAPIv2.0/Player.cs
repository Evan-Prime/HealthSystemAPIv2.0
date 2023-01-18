using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemAPIv2._0
{
    internal class Player
    {
        // fields
        int health; // declaration
        int lives; // declaration

        // methods
        public Player() // constructor
        {
            // initialization
            health = 100;
            lives = 3;
        }

        public void TakeDamage(int hp)
        {
            if (hp < 0) return;
            health -= hp;
            if (health < 0) health = 0;
        }

        public void Heal(int hp)
        {
            if (hp < 0) return;
            health += hp;
            if (health > 100) health = 100;
        }

        public void ShowStats()
        {
            Console.WriteLine("Health = " + health);
            Console.WriteLine("lives = " + lives);
        }
    }
}
