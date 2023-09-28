namespace OOP_C__lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1)
            Console.Write("Enter \"x\" value: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Math.Sqrt(Math.Log(x * x - 4));
            Console.WriteLine("y = " + y);
            #endregion 1)

            #region 2)

            //try
            //{
            //    Console.WriteLine("Enter a natural number: ");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int[] sequence = new int[a];
            //    int[,] arr = new int[a, a];
            //    Random rand = new Random();
            //    for (int i = 0; i < a; i++)
            //    {
            //        for (int j = 0; j < a; j++)
            //        {
            //            arr[i,j] = rand.Next(-10, 10);
            //        }
            //    }
            //    Console.WriteLine("Random matrix:");
            //    for (int i = 0; i < a; i++)
            //    {
            //        for (int j = 0; j < a; j++)
            //        {
            //            Console.Write(arr[i,j] + "  ");
            //        }
            //        Console.WriteLine();
            //    }

            //     //Sum
            //    int lastElementIndex = -1;
            //    for (int i = 0; i < a; i++)
            //    {
            //        int sum = 0;
            //        for (int j = a - 1; j >= 0; j--)
            //        {
            //            if (arr[i, j] < 0)
            //            {
            //                lastElementIndex = j;
            //                break;
            //            }
            //        }
            //        for (int k = 0; k < lastElementIndex; k++)
            //        {
            //            sum += arr[i, k];
            //        }

            //        //Console.WriteLine($"Sum before the last negative element in {i + 1}-th row is: {sum}");
            //        sequence[i] = sum;
            //    }
            //    Console.Write("Sequence: ");
            //    for ( int i = 0; i < a; ++i)
            //    {
            //        Console.Write(sequence[i] + " ");
            //    }

            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Incorrect input: " + e.Message);
            //}
            #endregion 2)

            #region 3)
            //Console.WriteLine("Enter \n" +
            //                  "[1] - to reduce the fraction\n" +
            //                  "[2] - to add two fractions\n" +
            //                  "[3] - to multiply two fractions");
            //int num = int.Parse(Console.ReadLine());
            //if (num == 1)
            //{

            //    Console.Write("Enter a numerator: ");
            //    int numerator = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter a denominator: ");
            //    int denominator = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(numerator + "/" + denominator);

            //    Shortening(ref numerator, ref denominator);
            //    Console.WriteLine($"Result: {numerator} / {denominator}");


            //}
            //if (num == 2)
            //{
            //    Console.WriteLine("Enter the first fraction, use [/] to indicate a fractional line");
            //    int firstNum = EnterNumerator();
            //    int firstDenom = EnterDenominator();
            //    Console.WriteLine("Enter the second fraction: ");
            //    int secondNum = EnterNumerator();
            //    int secondDenom = EnterDenominator();

            //    (int num, int denom) result = Adding(firstNum, firstDenom, secondNum, secondDenom);

            //    FractionOutput(result.num, result.denom);


            //}
            //if (num == 3)
            //{
            //    Console.WriteLine("Enter the first fraction, use [/] to indicate a fractional line");
            //    int firstNum = EnterNumerator();
            //    int firstDenom = EnterDenominator();
            //    Console.WriteLine("Enter the second fraction: ");
            //    int secondNum = EnterNumerator();
            //    int secondDenom = EnterDenominator();

            //    (int num, int denom) result = Multiply(firstNum, firstDenom, secondNum, secondDenom);

            //    FractionOutput(result.num, result.denom);


            //}
            //Functions
            #region Functions
            static int NSD(int a, int b)
            {
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                return a;
            }

            static void Shortening(ref int num, ref int denom)
            {
                int nsd = NSD(num, denom);

                num /= nsd;
                denom /= nsd;
            }

            static (int, int) Adding(int num1, int denom1, int num2, int denom2)
            {
                int numResult = 0;
                // Знаходимо НСК знаменників
                int NSK = (denom1 * denom2) / NSD(denom1, denom2);

                // Знаходимо чисельник результату
                numResult = (num1 * (NSK / denom1)) + (num2 * (NSK / denom2));

                return (numResult, NSK);
            }

            static void FractionOutput(int num, int denom)
            {
                Console.WriteLine($"{num}/{denom}");
            }

            static (int, int) Multiply(int num1, int denom1, int num2, int denom2)
            {
                // Знаходимо чисельник і знаменник результату
                int numResult = num1 * num2;
                int denomResult = denom1 * denom2;

                return (numResult, denomResult);
            }

            static int EnterNumerator()
            {
                Console.Write("Numerator: ");
                return Convert.ToInt32(Console.ReadLine());
            }

            static int EnterDenominator()
            {
                Console.Write("Denominator: ");
                return Convert.ToInt32(Console.ReadLine());
            }
            #endregion Functions

            #endregion 3)


        }
    }
}