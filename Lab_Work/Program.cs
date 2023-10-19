using System;

namespace Lab_Work
{
    enum Type
    {
        budget,
        currency,
        deposit
    }
    enum Value
    {
        number,
        balance,
        type
    }
    enum ValueBuild
    {
        CountFlat,
        CountEntrance,
        Height,
        NumberOfFloors
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.Write("\nВведите номер задания для его проверки(1, 2, 3, 4) или 'break' для выхода из программы: ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                        AccountTask1 account1 = new AccountTask1();
                        Console.WriteLine();
                        account1.SetNumber(1010101);
                        account1.SetBalance(121312);
                        account1.SetType(Type.currency);
                        account1.Get(Value.number);
                        account1.Get(Value.type);
                        account1.Get(Value.balance);
                        break;
                    case "2":
                        Console.WriteLine();
                        AccountTask2 account2 = new AccountTask2();
                        account2.SetBalance(121312);
                        account2.SetType(Type.currency);
                        account2.Get(Value.number);
                        account2.Get(Value.type);
                        account2.Get(Value.balance);
                        Console.WriteLine();
                        AccountTask2 account3 = new AccountTask2();
                        account3.SetBalance(12131221);
                        account3.SetType(Type.budget);
                        account3.Get(Value.number);
                        account3.Get(Value.type);
                        account3.Get(Value.balance);
                        break;
                    case "3":
                        Console.WriteLine();
                        AccountTask3 account4 = new AccountTask3();
                        account4.SetBalance(1000);
                        account4.SetType(Type.currency);
                        account4.Get(Value.number);
                        account4.Get(Value.type);
                        account4.Get(Value.balance);
                        Console.WriteLine();
                        account4.UpBalance();
                        account4.Get(Value.balance);
                        Console.WriteLine();
                        account4.FromBalance();
                        account4.Get(Value.balance);
                        break;
                    case "4":
                        Console.WriteLine();
                        Build build1 = new Build();
                        build1.SetCountEntrance(4);
                        build1.SetCountHeight(15);
                        build1.SetCountFlat(80);
                        build1.SetCountNumberOfFloors(5);
                        build1.Get(ValueBuild.Height);
                        build1.Get(ValueBuild.CountEntrance);
                        build1.Get(ValueBuild.NumberOfFloors);
                        build1.Get(ValueBuild.CountFlat);
                        break;
                    case "break":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nДанного номера не существует или неправильно введён 'break'.");
                        break;
                }
            }
        }
    }
}