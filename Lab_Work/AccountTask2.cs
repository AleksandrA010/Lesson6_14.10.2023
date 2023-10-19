using System;


namespace Lab_Work
{
    class AccountTask2
    {
        public AccountTask2()
        {
            number += 1027;
        }
        static private int number = 1000;
        private int balance;
        private Type type;
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
