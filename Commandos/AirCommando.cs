using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando : Commando
    {
        // constructor
        public AirCommando(string name, string codeName, string[] tools) : base(name, codeName, tools)
        {
        }

        // method to parachuting
        public void Parachute()
        {
            Console.WriteLine($"Commando {this.MyCodeName} is parachuting.");
        }

        // override getStatusAttack method
        public override void getStatusAttack()
        {
            Console.WriteLine($"Air Commando with codename {this.MyCodeName} is attacking from the air.");
        }
    }
}
