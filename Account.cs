
using System;


namespace console_bank
{

	public class BankAccount
	{
		private Client client;
		private float balance;
		private string type;

		public BankAccount(Client Client, float Balance, string Type)
		{
			this.client = Client;
			this.balance = Balance;
			this.type= Type;
		}

		public void checkBalance()
        {
			Console.WriteLine(this.balance);
        }

		public void withdraw(float amount)
        {	
			if(amount> this.balance)

            {
				Console.WriteLine("Sorry! You don't have enough on your account.");
				return;
            }

			this.balance = this.balance - amount;


        }

		public void deposit(float amount)
		{
			if (amount < 0)
			{
				Console.WriteLine("Can't deposit negatif amount.");
				return;
			}
			this.balance = this.balance + amount;
			
		}


	}


}
