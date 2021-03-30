using System;


namespace console_bank
{

	public class Client
	{
		private int id;
		private string name;
		private DateTime dateJoined;
		public Client( string Name, DateTime DateJoined)
		{
			this.id = new Random().Next(100);
			this.name = Name;
			this.dateJoined = DateJoined;
		}

	}

}
