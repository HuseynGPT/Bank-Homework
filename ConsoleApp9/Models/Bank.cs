using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Bank
    {
		private List<Client> clients;

		public List<Client> Clients
        {
			get { return clients; }
			set { clients = value; }
		}

		public void ShowCardBalance(BankCard card)
		{
            Console.WriteLine($"BALANCE ---> {card.Balance}");
        }

	}
}
