using System;

namespace BasicAtmMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new AtmMachine(5000);
            var customer = new Customer();

            machine.AddMoney(1000);
            machine.InsertCard(customer);
            machine.GetMoney(500);

            Console.ReadKey();
        }
    }
}
