using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3WarmUpIfElse
{
    class IfElsePractice
    {
        static void Main(string[] args)
        {
            double payRate;
            double payRate2;

            Console.WriteLine("What is your hourly pay rate? ");
            payRate = Console.Read();

            double weeklyPayRate = payRate * 40;

            if(payRate < 7.50 || payRate > 49.99)
            {
                Console.WriteLine("What is your VALID hourly pay rate?");
                payRate2 = Convert.ToDouble(Console.ReadLine());
                double weeklyPayRate2 = payRate2 * 40;
                if(payRate2 < 7.50 || payRate2 > 49.99)
                {
                    Console.WriteLine("Stop entering invalid values!!");
                    Console.ReadLine();
                }
                if(payRate2 > 7.50 || payRate2 < 49.99)
                {
                    Console.WriteLine("Your hourly pay rate is ${0}.00 and weekly is ${1}.00", Math.Round(payRate2, 2), Math.Round(weeklyPayRate,2));
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Your hourly pay rate is ${0}.00 and weekly is ${1}.00", payRate, weeklyPayRate);
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
//Console.ReadLine();
