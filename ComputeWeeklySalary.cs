using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeWeeklySalary
{
    // By: Sarthak Gupta
    // Date: 4/19/2018
    // ComputeWeeklySalary.cs project
    class ComputeWeeklySalaryProject
    {
        public static void Main(string[] args) //Main() Method
        {
            //Here is where I will demonstrate both correct overloaded methods.
            Console.WriteLine("Demonstrating the first method.");
            ComputeWeeklySalary(500);
            Console.WriteLine(" ");
            Console.WriteLine("Demonstrating the second method.");
            ComputeWeeklySalary(500.15);
            Console.ReadLine();
        }

        //Below are the two overloaded methods:
        public static void ComputeWeeklySalary(int annualSalary)
        {
            int weeklySalary; //Storage variable for weekly salary
            weeklySalary = annualSalary / 52; //Dividing by 52 because 52 wk/yr.
            Console.WriteLine(Convert.ToString(weeklySalary)); //Displaying
        }
        public static void ComputeWeeklySalary(double annualSalary)
        {
            double weeklySalary; //Storage variable for weekly salary
            weeklySalary = annualSalary / 52; //Dividing by 52 because 52 wk/yr.
            Console.WriteLine(Convert.ToString(weeklySalary)); //Displaying
        }
    }
}
