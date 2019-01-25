using System;

namespace FunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 1;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter question number of program to execute it and Enter 0 to close");
                int number = Utility.IsInteger(Console.ReadLine());
                Console.WriteLine("num : {0}", number);
                switch (number)
                {
                    case 0:
                        return;
                    case 1:
                        UserName f = new UserName();
                        f.UserInput();
                        Console.ReadLine();
                        break;
                    case 2:
                        FlipCoin c = new FlipCoin();
                        c.Toss();
                        break;
                    case 3:
                        LeapYear ly = new LeapYear();
                        ly.Leap();
                        break;
                    case 4:
                        PowerOfTwo p = new PowerOfTwo();
                        p.PowerTwo(Convert.ToInt32(args[0]));
                        break;
                    case 5:
                        Harmonic h = new Harmonic();
                        h.NHarmonic();
                        break;
                    case 6:
                        PrimeFactors fa = new PrimeFactors();
                        fa.PrimeFactorsfor();
                        break;
                    case 7:
                        Gambler g = new Gambler();
                        g.GamblerGame();
                        break;
                    case 8:
                        Coupon co = new Coupon();
                        co.CouponGame();
                        break;
                    case 9:
                        ArrayTwoDim atd = new ArrayTwoDim();
                        atd.Array2D();
                        break;
                    default:
                        Console.WriteLine("Not yet created");
                        Console.ReadLine();
                        flag = 0;
                        break;
                }
            } while (flag == 1);
        }
    }
}
