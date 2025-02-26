using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_abstraction.Model
{
    abstract class Trainer
    {
        public string Name { get; set; }
        public string Experience { get; set; }

        public Trainer(string name , string experience)
        {
            Name = name;
            Experience = experience;
        }
        public abstract void conductTraining();

        public void showDetails()
        {
            Console.WriteLine($"Name: {Name}, Experience: {Experience}");
        }
    }
}
