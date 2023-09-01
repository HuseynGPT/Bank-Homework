using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Models
{
    internal class Client
    {
        public  Guid ID { get; set; }

        public string Name { get; set; }

        public string Surname{ get; set; }

        public int Age{ get; set; }


        public float Salary{ get; set; }

        public BankCard  bank_account{ get; set; }



        public Client()
        {
            
        }
        public Client(string name, string surname, int age , BankCard bankCard)
        {
            ID = Guid.NewGuid();
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            Random rand = new();
            this.Salary = rand.Next(1000);
            this.bank_account = bankCard;
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("     Bank Account Info       ");
            bank_account.Show();
            Console.WriteLine("--------------------------------------");
        }

    }
}
