using ConsoleApp9.Models;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

void SetConsoleText(string text)
{
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"     >>>{text}<<<        ");
    Console.BackgroundColor = ConsoleColor.Black;
}



dynamic key;
int row = 0;

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("      >>>Admin<<<     ");
Console.BackgroundColor = ConsoleColor.Black;
Console.WriteLine("      User     ");
Console.WriteLine("      Exit     ");

Bank KapitalBank = new();

Client c1 = new Client("Vusal", "Ceferli", 19, new BankCard("Kapital bank", "Birbank", "1111111111111111", "1001"));
Client c2 = new Client("Cavid", "Atamoglanov", 25, new BankCard("Kapital bank", "Birbank", "1616161616161616", "2022"));

List<Client> clients = new List<Client>();
clients.Add(c1);
clients.Add(c2);

while (true)
{
main_menu:
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (row == 0)
        {
            row = 2;
        }
        else
        {

            row--;
        }
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        if (row == 2)
        {
            row = 0;
        }
        else
        {

            row++;
        }
    }

    // Admin menu
    if (row == 0 && key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        Console.WriteLine("---------------------------Admin-----------------------");
        dynamic key_admin;
        int row_admin = 0;

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("      >>>Create new client<<<     ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine("      Show all users     ");
        Console.WriteLine("      Remove by name     ");
        Console.WriteLine("      Search By Name     ");
        Console.WriteLine("      Exit     ");


        while (true)
        {
            key_admin = Console.ReadKey();

            if (key_admin.Key == ConsoleKey.UpArrow)
            {
                if (row_admin == 0)
                {
                    row_admin = 4;
                }
                else
                {
                    row_admin--;
                }
            }

            else if (key_admin.Key == ConsoleKey.DownArrow)
            {
                if (row_admin == 4)
                {
                    row_admin = 0;
                }
                else
                {
                    row_admin++;
                }
            }

            // Create new user
            if (row_admin == 0 && key_admin.Key == ConsoleKey.Enter)
            {

                try
                {
                    Console.Clear();
                    Client newClient = new();
                    string name, surname;
                    int age;
                    BankCard newCard = new();
                    Console.Write("Enter name: ");
                    name = Console.ReadLine();
                    newClient.Name = name;
                    Console.Write("Enter surname: ");
                    surname = Console.ReadLine();
                    newClient.Surname = surname;
                    Console.Write("Enter age: ");
                    age = int.Parse(Console.ReadLine());
                    newClient.Age = age;
                    Console.WriteLine("----Bank Account---");
                    Console.Write("Enter bank name: ");
                    string bankname = Console.ReadLine();
                    newCard.Bankname = bankname;
                    Console.Write("Enter full name: ");
                    string fullname = Console.ReadLine();
                    newCard.Fullname = fullname;
                    Console.Write("Enter PAN: ");
                    string PAN = Console.ReadLine();
                    newCard.Pan = PAN;
                    Console.Write("Enter PIN: ");
                    string PIN = Console.ReadLine();
                    newCard.Pin = PIN;

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Successfuly created");
                    Console.BackgroundColor = ConsoleColor.Black;
                    clients.Add(newClient);
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Have problem!!!!!");
                    Console.WriteLine(ex.Message);
                    Console.BackgroundColor = ConsoleColor.Black;

                }
                finally
                {
                    Console.WriteLine("Press any key to go back");
                    Console.ReadKey();
                }

            }
            //SHOW ALL USERS
            if (row_admin == 1 && key_admin.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                foreach (var item in clients)
                {
                    item.Show();
                }
                Console.WriteLine("Press any key to go back");
                Console.ReadKey();
            }
            // remove by name
            if (row_admin == 2 && key_admin.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Enter name: ");
                bool checker = false;
                string name = Console.ReadLine();
                foreach (var item in clients)
                {
                    if (item.Name == name)
                    {
                        clients.Remove(item);
                        checker = true;
                        break;
                    }
                }
                if (checker)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Succesfuly deleted!!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Name not found");
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine("Press any key to go back");
                Console.ReadKey();
            }
            //Search by name
            if (row_admin == 3 && key_admin.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.Write("Enter name: ");
                bool checker = false;
                string name = Console.ReadLine();
                foreach (var item in clients)
                {
                    if (item.Name == name)
                    {
                        Console.Clear();
                        item.Show();
                        checker = true;
                        break;
                    }
                }
                if (checker)
                {

                }
                else
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Name not found");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine("Press any key to go back");
                Console.ReadKey();
            }
            //Exit
            if (row_admin == 4 && key_admin.Key == ConsoleKey.Enter)
            {
                break;
            }


            Console.Clear();
            Console.WriteLine("---------------------------Admin-----------------------");
            if (row_admin == 0) { SetConsoleText("Create new user"); }
            else { Console.WriteLine("         Create new user           "); }
            if (row_admin == 1) { SetConsoleText("Show all users"); }
            else { Console.WriteLine("         Show all users          "); }
            if (row_admin == 2) { SetConsoleText("Remove by name"); }
            else { Console.WriteLine("         Remove by name          "); }
            if (row_admin == 3) { SetConsoleText("Search by name"); }
            else { Console.WriteLine("         Search by name          "); }
            if (row_admin == 4) { SetConsoleText("Exit"); }
            else { Console.WriteLine("         Exit          "); }



        }

    }

    // User menu
    if (row == 1 && key.Key == ConsoleKey.Enter)
    {
        Console.Clear();
        Console.SetCursorPosition(50, 10);
        Console.Write("Enter your card pin: ");
        string PIN = Console.ReadLine();
        bool checker = false;
        Client cc = new();
        foreach (var item in clients)
        {
            if (item.bank_account.Pin == PIN)
            {
                cc = item;
                checker = true;
                break;
            }
        }
        if (checker)
        {
            user:
            Console.Clear();
            Console.SetCursorPosition(40, 0);

            Console.WriteLine("----------Make a choice---------");
            Console.WriteLine("\n1.Balance\n2.Nagd pul\n3.Kartdan karta kocurme");
            Console.SetCursorPosition(40, 10);
            Console.Write("Seciminizi daxi edin: ");
            string choice = Console.ReadLine();
            //Show balace
            if (choice == "1")
            {
                Console.Clear();
                Console.WriteLine($"Balansiniz: {cc.bank_account.Balance} AZN");
                Console.WriteLine("Press any key to go back");
                Console.ReadKey();
                goto user;
            }
            // Balansdan pul cekmek
            else if (choice == "2")
            {
                Console.Clear();
                string inpt;
                Console.WriteLine("1.10 AZN\n2.20 AZN\n3.30 AZN\n4.40 AZN\n5.Ozunuz daxil edin");
                inpt = Console.ReadLine();
                if (inpt == "1")
                {
                    Console.Clear();
                    if (cc.bank_account.Balance >= 10)
                    {
                        cc.bank_account.Balance -= 10;
                        Console.WriteLine("Balansinizda 10 AZN cixildi");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz kifayet qeder deyil");
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                if (inpt == "2")
                {
                    Console.Clear();
                    if (cc.bank_account.Balance >= 20)
                    {
                        cc.bank_account.Balance -= 20;
                        Console.WriteLine("Balansinizda 20 AZN cixildi");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz kifayet qeder deyil");
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                if (inpt == "3")
                {
                    Console.Clear();
                    if (cc.bank_account.Balance >= 30)
                    {
                        cc.bank_account.Balance -= 30;
                        Console.WriteLine("Balansinizda 30 AZN cixildi");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz kifayet qeder deyil");
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                if (inpt == "4")
                {
                    Console.Clear();
                    if (cc.bank_account.Balance >= 40)
                    {
                        cc.bank_account.Balance -= 40;
                        Console.WriteLine("Balansinizda 40 AZN cixildi");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz kifayet qeder deyil");
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                }
                if (inpt == "5")
                {
                    float inptBalance = float.Parse(Console.ReadLine());
                    Console.Clear();
                    if (cc.bank_account.Balance >= inptBalance)
                    {
                        cc.bank_account.Balance -= inptBalance;
                        Console.WriteLine($"Balansinizda {inptBalance} AZN cixildi");
                    }
                    else
                    {
                        Console.WriteLine("Balansiniz kifayet qeder deyil");
                    }

                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    goto user;
                }


            }
            // Kartdan karta pul kocurmek
            else if(choice == "3")
            {
                Console.Clear();
                Console.Write("Kocurmek istedeiyiniz kartin PAN ni yazin: ");
                string PAN = Console.ReadLine();
                bool Ischecker = false;
                Client cc2 = new();
                foreach (var item in clients)
                {
                    if (item.bank_account.Pan == PAN)
                    {
                        checker = true;
                        cc2 = item;
                        break;
                    }
                }
                if (checker)
                {
                    Console.Clear();
                    string inpt;
                    Console.WriteLine("1.10 AZN\n2.20 AZN\n3.30 AZN\n4.40 AZN\n5.Ozunuz daxil edin");
                    inpt = Console.ReadLine();
                    if (inpt == "1")
                    {
                        Console.Clear();
                        if (cc.bank_account.Balance >= 10)
                        {
                            cc.bank_account.Balance -= 10;
                            cc2.bank_account.Balance -= 10;
                            Console.WriteLine("Balansinizda 10 AZN cixildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil");
                        }

                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    if (inpt == "2")
                    {
                        Console.Clear();
                        if (cc.bank_account.Balance >= 20)
                        {
                            cc.bank_account.Balance -= 20;
                            cc2.bank_account.Balance += 20;
                            Console.WriteLine("Balansinizda 20 AZN cixildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil");
                        }

                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    if (inpt == "3")
                    {
                        Console.Clear();
                        if (cc.bank_account.Balance >= 30)
                        {
                            cc.bank_account.Balance -= 30;
                            cc2.bank_account.Balance += 30;
                            Console.WriteLine("Balansinizda 30 AZN cixildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil");
                        }

                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    if (inpt == "4")
                    {
                        Console.Clear();
                        if (cc.bank_account.Balance >= 40)
                        {
                            cc.bank_account.Balance -= 40;
                            cc2.bank_account.Balance += 40;
                            Console.WriteLine("Balansinizda 40 AZN cixildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil");
                        }

                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    if (inpt == "5")
                    {
                        float inptBalance = float.Parse(Console.ReadLine());
                        Console.Clear();
                        if (cc.bank_account.Balance >= inptBalance)
                        {
                            cc.bank_account.Balance -= inptBalance;
                            cc2.bank_account.Balance += inptBalance;
                            Console.WriteLine($"Balansinizda {inptBalance} AZN cixildi");
                        }
                        else
                        {
                            Console.WriteLine("Balansiniz kifayet qeder deyil");
                        }

                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Not finding");
                   
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                goto user;

            }

        }
        else
        {
            Console.Clear();
            Console.WriteLine("Not finding");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

    }

    if (row == 2 && key.Key == ConsoleKey.Enter)
    {
        break;
    }


        Console.Clear();
    if (row == 0) { SetConsoleText("Admin"); }
    else { Console.WriteLine("         Admin           "); }
    if (row == 1) { SetConsoleText("User"); }
    else { Console.WriteLine("         User          "); }
    if (row == 2) { SetConsoleText("Exit"); }
    else { Console.WriteLine("         Exit          "); }


}
