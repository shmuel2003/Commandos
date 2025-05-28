using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando : Commando, ISwim
    {
        // constructor
        public SeaCommando(string name, string codeName, string[] tools) : base(name, codeName, tools)
        {
        }
        // method to dive
        public void Dive()
        {
            Console.WriteLine($"Commando {this.MyCodeName} is diving.");
        }

        // override getStatusAttack method
        public override void getStatusAttack()
        {
            Console.WriteLine($"Sea Commando with codename {this.MyCodeName} is attacking from the sea.");
        }
    }
}
