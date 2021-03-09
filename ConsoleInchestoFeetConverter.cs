using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToFeet
{
    class ConsoleInchestoFeetConverter
    {
        public static void Main(string[] args)
        {
            int inches;
            Console.WriteLine("Enter a value inches: ");
            inches = Convert.ToInt32(Console.ReadLine());
            InchesToFeet(inches);
        }
        public static void InchesToFeet(int inchValue)
        {
            int InchesInInches; // For the extra inches left over.
            int FeetFromInches; // For the value of feet

            FeetFromInches = inchValue / 12;
            InchesInInches = inchValue % 12;

            //Adding if statements below for the inch vs. inches in output.
            if(InchesInInches > 1)
            {
                Console.WriteLine("{0} inches is {1} feet and {2} inches!", inchValue, FeetFromInches, InchesInInches);
                Console.ReadLine();
            }
            else if(InchesInInches == 0)
            {
                Console.WriteLine("{0} inches is {1} feet!", inchValue, FeetFromInches);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} inches is {1} feet and {2} inch!", inchValue, FeetFromInches, InchesInInches);
                Console.ReadLine();
            }


        }
    }
}
