using System;

namespace console_bank
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your balance?");
            float userBalance = float.Parse(Console.ReadLine());

            Console.WriteLine("What is your account type?");
            string accountType = Console.ReadLine();

            Client client = new Client(userName, DateTime.Now);
            BankAccount account = new BankAccount(client, userBalance, accountType);

            Console.WriteLine("Make a choice deposit or withdraw");

            string choice = Console.ReadLine().ToLower();
            

            if (choice == "deposit")
            {
                Console.WriteLine("Enter the amount :");
                float amount = float.Parse(Console.ReadLine());
                account.deposit(amount);
            }
            if(choice == "withdraw")
            {
                Console.WriteLine("Enter the amount :");
                float amount = float.Parse(Console.ReadLine());
                account.withdraw(amount);
            }


            Console.WriteLine("Your current balance is : ");
            account.checkBalance();
         
            
        }
    }
}


