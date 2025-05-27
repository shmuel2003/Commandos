using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("John Doe", "EagleEye", new string [5] { "Knife", "Grenade", "Rope", "Flashlight", "Map" });
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            Console.WriteLine(commando.SayName("GENERAL"));
            commando.MyCodeName = "sh";
            Console.WriteLine(commando.MyCodeName);
            Console.WriteLine(weapon.manufacturer);
        }
    }
}
