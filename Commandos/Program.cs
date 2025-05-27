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
            Weapon weapon = new Weapon("AK-47", "Kalashnikov", 30);
            Commando commando = new Commando("John Doe", "EagleEye", new string [5] { "Knife", "Grenade", "Rope", "Flashlight", "Map" });
            AirCommando airCommando = new AirCommando("Jane Smith", "SkyHawk", new string[5] { "Parachute", "Binoculars", "Radio", "First Aid Kit", "Compass" });
            SeaCommando seaCommando = new SeaCommando("Mike Johnson", "WaveRider", new string[5] { "Diving Gear", "Harpoon", "Flippers", "Oxygen Tank", "Underwater Camera" });
            Commando[] typeCommandos = new Commando[3] {commando, airCommando, seaCommando};
            foreach (Commando c in typeCommandos)
            {
                c.getStatusAttack();
            }
            Console.WriteLine(commando.SayName("GENERAL"));
            commando.MyCodeName = "Shadow";
            Console.WriteLine(commando.MyCodeName);
            Console.WriteLine(weapon.manufacturer);
        }
    }
}
