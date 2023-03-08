using System;
using System.Xml.Linq;

namespace Lab1
{
    class Program
    {
        class TCircle
        {
            public double r { get; set; }

            public TCircle()
            {
                r = 9;

            }

            public TCircle(TCircle o) 
            {
                this.r = o.r;

            }
            public TCircle(double _r) 
            {
                this.r = _r;

            }

            public virtual double area()
            {
                return Math.PI * Math.Pow(r, 2);
            }

            public double length()
            {
                return 2*Math.PI * r;
            }

            public virtual double sectorArea(double angle)
            {
                return area()*(angle%360)/360;
            }


            public static TCircle operator +(TCircle TCircle1, TCircle TCircle2)
            {
                return new TCircle { r = TCircle1.r + TCircle2.r};
            }
            public static TCircle operator -(TCircle TCircle1, TCircle TCircle2)
            {
                return new TCircle { r = TCircle1.r - TCircle2.r};
            }

            public static TCircle operator *(TCircle TCircle1, double k)
            {
                return new TCircle { r = TCircle1.r * k };
            }
        }

        class TCone : TCircle
        {
            public double h { get; set; }

            public TCone() : base()
            {
                h = 9;

            }

            public TCone(TCone o) : base(o) //копіювання
            {
                this.h = o.h;

            }
            public TCone(double _r,double _h) : base(_r) //параметрично
            {
                this.h = _h;

            }
            public override double area()
            {
                return Math.PI * r * Math.Sqrt(Math.Pow(r,2)+ Math.Pow(h,2));
            }

            public double size()
            {
                return Math.PI * h * Math.Pow(r,2) /3;
            }

        
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 - Enter data");
            Console.WriteLine("2 - Print data");
            Console.WriteLine("3 - Print Area and Sector Area");
            Console.WriteLine("4 - Print Lenght");
            Console.WriteLine("5 - Redefinition");
            Console.WriteLine("6 - Go to the TCone");
            Console.WriteLine("0 - exit");
            TCircle c = new TCircle();

            while (true)
            {
                Console.Write("Choose next option: ");
                int x = Convert.ToInt32(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Write("Enter data: ");
                        var s1 = Console.ReadLine().Split(' ');
                        try
                        {
                            c.r = Convert.ToDouble(s1[0]);
                  

                        }
                        catch
                        {
                            Console.WriteLine("Incorrect data");
                        }
                        finally
                        {

                            if (c.r < 0)
                            {
                                Console.WriteLine("r < 0, r=0 ");
                                c.r = 0;
                            }

                        }
                        break;
                    case 2:
                        Console.WriteLine("r={0};", c.r);
                        break;
                    case 3:
                        Console.WriteLine("Area={0};", Math.Round(c.area(), 2));
                        Console.Write("Enter angle: ");
                        var s3 = Console.ReadLine().Split(' ');
                        double angle = Convert.ToDouble(s3[0]);
                        Console.WriteLine("Area={0};", Math.Round(c.sectorArea(angle), 2));
                        break;
                    case 4:
                        Console.WriteLine("Lenght={0};", Math.Round(c.length(), 2));
                        break;
                    case 5:
                        Console.Write("Enter second radius: ");
                        TCircle c2 = new TCircle();
                        var s4 = Console.ReadLine().Split(' ');
                        c2.r = Convert.ToDouble(s4[0]);
      
                        Console.WriteLine("r={0};", c2.r);
                        TCircle c3 = c + c2;
                        Console.WriteLine("Addition: r={0};", c3.r);
                        try
                        {
                            c3 = c - c2;
                        }
                        finally
                        {
                            if (c3.r < 0)
                            {
                                Console.WriteLine("Subtraction: the radius is negative");
                            }
                            else
                            {
                                Console.WriteLine("Subtraction: r={0};", c3.r);
                            }
                        }
                       
                        Console.WriteLine("Enter n: ");
                        double n = Convert.ToDouble(Console.ReadLine());
                        c3 = c * n;
                        Console.WriteLine("Multiplication: r={0};", c3.r);
                        break;
                    case 6:
                        TCone con = new TCone();
                        Console.WriteLine("1 - Enter data");
                        Console.WriteLine("2 - Print data");
                        Console.WriteLine("3 - Print Area");
                        Console.WriteLine("4 - Print Size");
                        Console.WriteLine("0 - Exit");

                        while (true)
                        {
                            Console.Write("Choose next option: ");
                            int x1 = Convert.ToInt32(Console.ReadLine());
                            switch (x1)
                            {
                                case 1:
                                    Console.WriteLine("Enter r and h:");
                                    var ss = Console.ReadLine().Split(' ');
                                    con.r = Convert.ToDouble(ss[0]);
                                    con.h = Convert.ToDouble(ss[1]);
                                    break;
                                case 2:
                                    Console.WriteLine("r={0}; h={1};", con.r, con.h);
                                    break;
                                case 3:
                                    Console.WriteLine("Area={0};", Math.Round(con.area(), 2));
                                    break;
                                case 4:
                                    Console.WriteLine("Size={0};", Math.Round(con.size(), 2));
                                    break;
                            }
                            if (x1 == 0)
                            {
                                Console.WriteLine("Return to TCircle");
                                break;
                            }
                        }

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
