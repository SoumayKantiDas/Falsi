using System;

namespace Falsi
{
    class Program
    {
       

            static void Main(string[] args)
            { 

                double C;
                double precision;
                double power;
                double a;
                double b;
                double c;
                double d;
                double e;
                double intervalBegin;
                double intervalEnd;
            To:
                Console.Write("Enter begining of interval: ");
                intervalBegin = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter end of interval: ");
                intervalEnd = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter precision of method: ");
                precision = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter The power of the equation: ");
                power = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Coefficient values of a: of ax^4+bx^3+cx^2+dx+e: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Coefficient values of b: of ax^4+bx^3+cx^2+dx+e: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Coefficient values of c: of ax^4+bx^3+cx^2+dx+e: ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Coefficient values of d: of ax^4+bx^3+cx^2+dx+e: ");
                d = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the value of the constant: ");
                e = Convert.ToDouble(Console.ReadLine());
                if (intervalBegin > intervalEnd)
                {
                    Console.WriteLine("Interval begain is grater than intervalend");
                    return;
                }

                if (Function(intervalBegin, power, a, b, c, d, e) * Function(intervalEnd, power, a, b, c, d, e) > 0.0D)
                {
                    Console.Write("Function has same signs at ends of interval");
                    goto To;
                }
            C = ((intervalBegin * Function(intervalEnd, power, a, b, c, d, e) - intervalEnd * Function(intervalBegin, power, a, b, c, d, e)) / (Function(intervalEnd, power, a, b, c, d, e) - Function(intervalBegin, power, a, b, c, d, e)));

               

                while (Math.Abs(intervalBegin - intervalEnd) > precision)
                {
                C = ((intervalBegin * Function(intervalEnd, power, a, b, c, d, e) - intervalEnd * Function(intervalBegin, power, a, b, c, d, e)) / (Function(intervalEnd, power, a, b, c, d, e) - Function(intervalBegin, power, a, b, c, d, e)));
                if ((Function(C, power, a, b, c, d, e) == 0))
                {

                    Console.WriteLine("X: " + C);
                    return;
                }
                //C = ((intervalBegin * Function(intervalEnd, power, a, b, c, d, e) - intervalEnd * Function(intervalBegin, power, a, b, c, d, e) )/ (Function(intervalEnd, power, a, b, c, d, e) - Function(intervalBegin, power, a, b, c, d, e)));
                Console.WriteLine("X: " + C);
                    if (Function(intervalBegin, power, a, b, c, d, e) * Function(C, power, a, b, c, d, e) < 0.0D)
                    {
                        intervalEnd = C;
                    }
                    else
                    {
                        intervalBegin = C;
                    }
                }
                Console.ReadKey();
            }
            static double Function(double x, double Power, double A, double B, double C, double D, double E)
            {
                if (Power == 4)
                {
                    return A * (x * x * x * x) + B * (x * x * x) + C * (x * x) + D * (x) + E;
                }
                else if (Power == 3)
                {
                    return B * (x * x * x) + C * (x * x) + D * (x) + E;
                }
                else if (Power == 2)
                {
                    return C * (x * x) + D * (x) + E;
                }

                else if (Power == 2)
                {
                    return C * (x * x) + D * (x) + E;
                }
                else
                {
                    return D * (x) + E;
                }


            }
            
        }

    }
