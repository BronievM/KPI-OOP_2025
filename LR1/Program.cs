namespace LR1
{
    internal class Program
    {
        class Calculate
        {
            public int Number { get; set; }
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
                Console.WriteLine($"C2={C2}, C3={C3}, C5={C5}, C7={C7}");
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
                            case 1: 
                                { 
                                    if (indexJ != 0) temp = (double)indexI / indexJ;
                                    else temp = 0; 
                                    break; 
                                }
                            case 2:
                                {
                                    if (indexJ != 0) temp = indexI % indexJ;
                                    else temp = 0;
                                    break;
                                }
                            case 3: temp = indexI + indexJ; break;
                            case 4: temp = indexI - indexJ; break;
                        }

                        if (IsAdding)
                        {
                            if (indexI + C3 != 0)
                                Sum += temp / (indexI + C3);
                            else
                                Sum += temp / 1; 
                        }
                        else
                        {
                            if (indexI - C3 != 0)
                                Sum += temp / (indexI - C3);
                            else
                                Sum += temp / 1; 
                        }

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
            Console.WriteLine($"Варiант: {number}");
            Console.Write("Введiть n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введiть m: ");
            int m = int.Parse(Console.ReadLine());

            Calculate calc = new Calculate(number);
            Console.WriteLine($"Результат обчислення: {calc.Calculation(n, m)}");
        }
    }
}
