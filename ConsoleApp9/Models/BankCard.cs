using System.Linq.Expressions;
using System.Reflection.PortableExecutable;

namespace ConsoleApp9.Models
{
    internal class BankCard
    {
		private	string bankName;

		public  string Bankname
		{
			get { return bankName; }
			set { if (value.Length >= 3) { this.bankName = value; } else { throw new Exception("bankname is wrong"); } }
		}

        private string fullname;

        public string Fullname
        {
            get { return fullname; }
            set { if (value.Length >= 3) { this.fullname = value; } else { throw new Exception("fullname is wrong"); } }
        }

		private string PAN;

		public string Pan
		{
			get { return PAN; }
			set
			{
				if (value.Length==16)
				{
					this.PAN = value;
				}
				else
				{
					throw new Exception("pan is wrong");
				}
			}
		}

        private string PIN;

        public string Pin
        {
            get { return PIN; }
            set
            {
                if (value.Length == 4)
                {
                    this.PIN = value;
                }
                else
                {
                    throw new Exception("PIN is wrong");
                }
            }
        }

        public string CVC{ get; set; }

        public string expiresDate { get; set; }

        public float Balance{ get; set; }

        public BankCard()
        {
            
        }


        public BankCard(string bankName, string fullname, string PAN, string PIN)
        {
            this.bankName = bankName;
            this.fullname = fullname;
            this.PAN = PAN;
            this.PIN = PIN;
            Random rand = new();
            int number = rand.Next(100, 999);
            this.CVC = number.ToString();
            this.expiresDate = DateTime.Now.Year.ToString();
            this.Balance = 5000;
        }

        public void Show()
        {
            Console.WriteLine($"Small bank name: {bankName}");
            Console.WriteLine($"Full bank name: {fullname}");
            Console.WriteLine($"PAN: {PAN}");
            Console.WriteLine($"PIN: {PIN}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"Expires Date: {expiresDate}");
            Console.WriteLine($"Balance: {Balance}");
        }


    }
}
