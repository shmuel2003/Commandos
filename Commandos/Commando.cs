using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        // instance
        private string name;
        private string CodeName;
        public string [] Tools;
        public string status;

        // constructor
        public Commando(string name, string codeName, string[] tools)
        {
            this.name = name;
            this.CodeName = codeName;
            this.Tools = tools;
            this.status = "Standing"; // default status
        }
        
        // setStatusWalk
        public void setStatusWalk()
        {
            this.status = "Walking";
            Console.WriteLine($"The soldier is {this.status}.");
        }
        
        // setStatusHide
        public void setStatusHide()
        {
            this.status = "Hiding";
            Console.WriteLine($"The soldier is {this.status}.");
        }

        // getStatusAttack
        public void getStatusAttack()
        {
            Console.WriteLine($"Commando with codename {this.CodeName} is attack.");
        }
        
        // get name
        public string SayName(string commanderRank)
        {
            switch (commanderRank)
            {
                case "GENERAL":
                    return this.name;
                case "COLONEL":
                    return this.CodeName;
                default:
                    return "The information cannot be provided because it is classified.";
            }
        }
        
        // get and set
        public string MyCodeName
        {
            get { return this.CodeName; }
            set { this.CodeName = value; }
        }
    }
}
