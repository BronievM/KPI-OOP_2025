namespace LR1
{
    internal class Program
    {
        class Calculate
        {
            public int Number { get; set; }
            private bool OperationAdding;
            public Calculate(int number)
            {
                Number = number;
            }

            public double Calculation(int n, int m)
            {
                int C2 = Number % 2;
                int C3 = Number % 3;
                int C5 = Number % 5;
                int C7 = Number % 7;
                bool IsAdding = false;
                double Sum = 0;

                if (C2 == 0) IsAdding = true;

                for(int i = 0; i <= n; i++)
                {
                    for(int j = 0; j <= m; j++)
                    {
                        dynamic indexI = ConvertIndexType(i, C7);
                        dynamic indexJ = ConvertIndexType(j, C7);

                        double temp = 0;
                        switch (C5)
                        {
                            case 0: temp = indexI * indexJ; break;
                            case 1: temp = indexJ != 0 ? (double)indexI / indexJ : 0; break;
                            case 2: temp = indexJ != 0 ? indexI % indexJ : 0; break;
                            case 3: temp = indexI + indexJ; break;
                            case 4: temp = indexI - indexJ; break;
                        }

                        if (IsAdding) Sum += temp + C3;
                        else Sum += temp - C3;

                    }
                }


                return Sum;
            }

            private dynamic ConvertIndexType(int value, int C7)
            {
                switch (C7)
                {
                    case 0: return (byte)value;
                    case 1: return (short)value;
                    case 2: return (int)value;
                    case 3: return (long)value;
                    case 4: return (char)value;
                    case 5: return (float)value;
                    case 6: return (double)value;
                    default: throw new Exception("Невідомий тип індексів");
                }
            }

        }


        static void Main(string[] args)
        {
            int number = 4218;
            Calculate calc = new Calculate(number);
            double result = calc.Calculation(5, 5);

            Console.WriteLine("Результат обчислення: " + result);
        }
    }
}
