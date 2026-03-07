//Bank Xidmeti
using System.Runtime.InteropServices;

Console.WriteLine("Enter your name:");
string name = Console.ReadLine();

Console.WriteLine("Enter your balance:");
double balance = Convert.ToDouble(Console.ReadLine());


int limit = 2000;

while (true)
{
    Console.WriteLine("Select:");
    Console.WriteLine("1-Show balance");
    Console.WriteLine("2-Get money");
    Console.WriteLine("3-Add money");
    Console.WriteLine("4-Exit");

    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:

            Console.WriteLine($"Your balance - {balance}");
            break;

        case 2:

            Console.WriteLine("Enter the amount you want to spend:");

            double getMoney = Convert.ToDouble(Console.ReadLine());
            double commision = getMoney * 1.01;

            if (getMoney > 2000)
            {
                if (commision <= balance)
                {
                    balance -= commision;

                    Console.WriteLine($"A commission of {getMoney * 0.01} - manat was charged from your account.");

                }
                else
                {
                    Console.WriteLine("You do not have enough funds in your balance.");
                }
            }
            else if(getMoney<= balance)
            {
                balance -= getMoney;
            }
            else
            {
                Console.WriteLine("You do not have enough funds in your balance.");
            }

                Console.WriteLine($"Your current balance {balance}");

            break;

        case 3:

            Console.WriteLine("Enter the amount you want to increase:");
            double daxil = Convert.ToDouble(Console.ReadLine());

            if (daxil > limit)
            {
                Console.WriteLine($"The input limit is {limit}");
            }
            else
            {
                balance += daxil;
                Console.WriteLine($"Your current balance {balance}");
            }

            break;
        case 4:

            Console.WriteLine($"Good bye {name}!");
            break;

        default:
            Console.WriteLine("You didn't make the right choice.");
            break;
    }

    if (option == 4)
    {
        break;
    }
}