using System;

namespace Lab_Work
{
    class AccountTask1
    {
        private int number;
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
        public void SetNumber(int int_)
        {
            number = int_;
        }
        public void SetType(Type type)
        {
            this.type = type;
        }
        
    }
}
