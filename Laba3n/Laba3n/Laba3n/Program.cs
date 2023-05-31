using System;
using System.Xml.Linq;

namespace Lab1
{
    class Program
    {
        class Number
        {
            public double num1 { get; set; }
            public double num2 { get; set; }

            public Number()
            {
                num1 = 10;
                num2 = 5;

            }
            public Number(Number o)
            {
                this.num1 = o.num1;
                this.num2 = o.num2;

            }
            public Number(double _num1, double _num2)
            {
                this.num1 = _num1;
                this.num2 = _num2;
            }
            public double Difference()
            {
                return num1 - num2;
            }
            public double Summ()
            {
                return num1 + num2;
            }

            public int ConvertRomanToArabic(string romanNumber)
            {
                //if (string.IsNullOrEmpty(romanNumber))
                //    throw new ArgumentException("a roman numeral cannot be empty");

                Dictionary<char, int> romanValues = new Dictionary<char, int>()
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };

                int result = 0;
                int previousValue = 0;

                for (int i = romanNumber.Length - 1; i >= 0; i--)
                {
                    char currentSymbol = romanNumber[i];

                    //if (!romanValues.ContainsKey(currentSymbol))
                    //    throw new ArgumentException($"incorrect data: {currentSymbol}");

                    int currentValue = romanValues[currentSymbol];

                    if (currentValue >= previousValue)
                        result += currentValue;
                    else
                        result -= currentValue;

                    previousValue = currentValue;
                }

                return result;
            }

            public double DivideString(string input)
            {
                string[] parts = input.Split('/');
                double numerator = double.Parse(parts[0]);
                double denominator = double.Parse(parts[1]);

                if (denominator == 0)
                {
                    Console.WriteLine("The denominator cannot be zero");
                    return numerator;
                }

                return numerator / denominator;
            }
        }


        static void Main(string[] args)
        {
            //string romanNumber = "XIV";
            //double arabicNumber = ConvertRomanToArabic(romanNumber);
            //Console.WriteLine($"Result1: {arabicNumber}");
            //string res = "4/8";
            //double r = DivideString(res);
            //Console.WriteLine($"Result2: {r}");

            Console.WriteLine("1 - Enter the first number");
            Console.WriteLine("2 - Enter the second number");
            Console.WriteLine("3 - Print data");
            Console.WriteLine("4 - Find the sum of the numbers");
            Console.WriteLine("5 - Find the difference of numbers");
            Console.WriteLine("0 - exit");
            Number number = new Number();

            while (true)
            {

                Console.Write("Choose next option: ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("1 - Roman numeral");
                        Console.WriteLine("2 - Fractional number");
                        Console.WriteLine("3 - Integer");
                        Console.WriteLine("0 - exit");
                        Console.Write("Choose a method: ");

                        int x1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new data: ");
                        var s1 = Console.ReadLine().Split(' ');
                        string str = s1[0];

                        switch (x1)
                        {
                            case 1:
                                number.num1 = number.ConvertRomanToArabic(str);

                                break;
                            case 2:
                                number.num1 = number.DivideString(str);

                                break;
                            case 3:
                                number.num1 = Convert.ToDouble(str);


                                break;

                        }


                        Console.WriteLine("new num1=" + number.num1);
                        break;
                    case 2:
                        Console.WriteLine("1 - Roman numeral");
                        Console.WriteLine("2 - Fractional number");
                        Console.WriteLine("3 - Integer");
                        Console.WriteLine("0 - exit");
                        Console.Write("Choose a method: ");
                        int x2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new data: ");
                        var s2 = Console.ReadLine().Split(' ');
                        string str2 = s2[0];
                        switch (x2)
                        {
                            case 1:
                                number.num2 = number.ConvertRomanToArabic(str2);

                                break;
                            case 2:
                                number.num2 = number.DivideString(str2);

                                break;
                            case 3:
                                number.num2 = Convert.ToDouble(str2);


                                break;

                        }
                        Console.WriteLine("new num2=" + number.num2);
                        break;
                    case 3:

                        Console.WriteLine("num1=" + number.num1 + " num2=" + number.num2);
                        break;
                    case 4:
                        Console.WriteLine("Sum=" + number.Summ());
                        break;
                    case 5:
                        Console.WriteLine("Difference=" + number.Difference());
                        break;

                }
                if (x == 0)
                {
                    break;
                }
            }

        }
    }
}
