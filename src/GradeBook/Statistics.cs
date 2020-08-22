using System;

namespace GradeBook
{
    public class Statistics
    {

        public int Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public int High;
        public int Low;
        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90:
                        return 'A';
                    case var d when d >= 80:
                        return 'B';
                    case var d when d >= 70:
                        return 'C';
                    case var d when d >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }

        }

        public int Sum;
        public int Count;

        public void Add(int number)
        {
            Sum += number;
            Count += 1;

            Low = Math.Min(number, Low);
            High = Math.Max(number, High);

        }
        public Statistics()
        {
            Count = 0;
            Sum = 0;
            High = int.MinValue;
            Low = int.MaxValue;

        }
    }
}