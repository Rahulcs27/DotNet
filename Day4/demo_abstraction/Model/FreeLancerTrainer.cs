using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_abstraction.Model
{
    class FreeLancerTrainer : Trainer
    {
        public double HourlyRate { get; set; }

        public FreeLancerTrainer(string name, string experience, double hourlyRate) : base(name, experience)
        {
            HourlyRate = hourlyRate;
        }
        public override void conductTraining()
        {
            Console.WriteLine("Conducting training");
        }
        public void earning(int hours)
        {
            double earning = HourlyRate * hours;
            Console.WriteLine($"{Name} earned ${earning} for {hours} hours of training.");
        }
    }
}
