using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDEmo
{
    class Server
    {
        protected List<string> duties;
        protected double wages;
        public string Name { get; }
        public Server(string name)
        {
            Name = name;
            wages = 14;
            List<string> duties = new List<string>() { "cleaning", "serving", "taking request", "giving bill", "give order" };
        }
        public override string ToString()
        {
            return $"Name: {Name} wages:{wages:C}\nDuties:{string.Join(", ", duties) }";
        }
    }
        class Supervisor : Server
        {
            public Supervisor(string name)
             : base(name)
            {
                wages = 18.99;
                duties.Add("Make up the schedule");
            }
                
            
        }
        class Manager : Supervisor
        {
            public Manager(string name)
                : base(name)
            {
                wages = 20.99;
                duties.Add("ask the supervisor");
            }
        }

}

