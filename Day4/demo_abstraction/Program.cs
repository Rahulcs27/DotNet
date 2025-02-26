using demo_abstraction.Model;

namespace demo_abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FreeLancerTrainer trainer = new FreeLancerTrainer("Rahul","5",1000);
            trainer.showDetails();
            trainer.conductTraining();
            trainer.earning(10);

        }
    }
}
