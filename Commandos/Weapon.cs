using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        // instance
        public string name;
        public string manufacturer;
        public int NumberOfBalls;

        // constructor
        public Weapon(string name, string manufacturer, int numberOfBalls)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.NumberOfBalls = numberOfBalls;
        }

        // method prints a shot and reduces one bullet
        public void Shoot()
        {
            if (NumberOfBalls > 0)
            {
                Console.WriteLine($"Shot fired from {this.name} by {this.manufacturer}. Remaining bullets: {this.NumberOfBalls - 1}");
                this.NumberOfBalls--;
            }
            else
            {
                Console.WriteLine($"No bullets left in {this.name}.");
            }
        }
    }
}
