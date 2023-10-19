using System;

namespace Lab_Work
{
    internal class Build
    {
        public Build()
        {
            number += 1;
        }
        static private int number = 0;
        private int CountFlat;
        private int CountEntrance;
        private int Height;
        private int NumberOfFloors;
        public void Get(ValueBuild value)
        {
            switch (value)
            {
                case ValueBuild.CountFlat:
                    Console.WriteLine($"Количество квартир: {CountFlat}");
                    break;
                case ValueBuild.CountEntrance:
                    Console.WriteLine($"Количество подъездов: {CountEntrance}");
                    break;
                case ValueBuild.Height:
                    Console.WriteLine($"Высота: {Height}");
                    break;
                case ValueBuild.NumberOfFloors:
                    Console.WriteLine($"Количество этажей: {NumberOfFloors}");
                    break;
            }
        }
        public void SetCountFlat(int int_)
        {
            CountFlat = int_;
        }

        public void SetCountEntrance(int int_)
        {
            CountEntrance = int_;
        }
        public void SetCountHeight(int int_)
        {
            Height = int_;
        }
        public void SetCountNumberOfFloors(int int_)
        {
            NumberOfFloors = int_;
        }
    }
}
