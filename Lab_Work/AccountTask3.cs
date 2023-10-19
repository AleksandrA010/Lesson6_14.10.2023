using System;

namespace Lab_Work
{
    class AccountTask3
    {
        public AccountTask3()
        {
            number += 1027;
        }
        static private int number = 1000;
        private int balance;
        private Type type;
        public void UpBalance()
        {
            Console.Write("Введите сумму, которую хотите положить: ");
            int.TryParse(Console.ReadLine(), out int value);
            balance += value;
        }
        public void FromBalance()
        {
            Console.Write("Введите сумму, которую хотите снять: ");
            int.TryParse(Console.ReadLine(), out int value);
            if (balance >= value)
            {
                balance -= value;
            }
            else
            {
                Console.WriteLine("У вас недостаточно средств.");
            }
        }
        public void Get(Value value)
        {
            switch (value)
            {
                case Value.number:
                    Console.WriteLine($"Номер вашего счёта: #{number}");
                    break;
                case Value.balance:
                    Console.WriteLine($"Баланс вашего счёта: {balance} руб.");
                    break;
                case Value.type:
                    Console.WriteLine($"Тип вашего счёта: {type}");
                    break;
            }
        }
        public void SetBalance(int int_)
        {
            balance = int_;
        }

        public void SetType(Type type)
        {
            this.type = type;
        }


    }
}
