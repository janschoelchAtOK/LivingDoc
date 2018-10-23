using System;

namespace BasicAtmMachine
{
    public class AtmMachine
    {
        public AtmMachine(int initialMoney = 1000)
        {
            CurrentMoney = initialMoney;
            Console.WriteLine($"AtmMachine initialized and filled with {initialMoney}$");
        }

        #region Methods
        
        public void GetMoney(int money)
        {
            Console.WriteLine($"Customer {CurrentCustomer.Id} asked for {money}$");

            if (CardInserted == false || CurrentCustomer == null)
            {
                Console.WriteLine("Please insert a valid card first");
                return;
            }

            if (string.IsNullOrEmpty(CurrentCustomer.CardNo))
            {
                Console.WriteLine("I don't know this customer");
                RemoveCard();
                return;
            }

            if (CurrentMoney < money)
            {
                Console.WriteLine("I do not have enough money, sorry!");
            }

            CurrentMoney -= money;
            Console.WriteLine($"There you go, here you have {money}$");
            Console.WriteLine($"CurrentMoney is now {CurrentMoney}$");

            RemoveCard("Thank you and good bye!");
        }

        public void AddMoney(int money)
        {
            CurrentMoney += money;
            Console.WriteLine($"Added {money}$, now there is {CurrentMoney}$ in the machine!");
        }

        public void RemoveCard(string message = null)
        {
            Console.WriteLine("Card is being removed...");

            if (CardInserted == false)
            {
                Console.WriteLine("There is no card to remove");
            }

            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }

            CurrentCustomer = null;
            CardInserted = false;
        }

        public void InsertCard(Customer customer)
        {
            if (CardInserted)
            {
                Console.WriteLine("Card is already inserted");
                return;
            }

            CurrentCustomer = customer;
            CardInserted = true;

            Console.WriteLine($"Welcome, Customer {CurrentCustomer.Id}!");
        }

        #endregion

        #region Properties

        public bool CardInserted { get; set; }

        public int CurrentMoney { get; set; }

        public Customer CurrentCustomer { get; set; }
        
        #endregion
    }
}