using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4SwitchStatementsWU
{
    class SwitchStatementPractice
    {
        static void Main(string[] args)
        {
            int Input;
            Console.WriteLine("Enter a number between 1 and 10");
            Input = Convert.ToInt32(Console.ReadLine());

            if (Input > 10)
            {
                Console.WriteLine("Out of range");
            }
            else
            {
                switch (Convert.ToInt32(Input))
                {
                    case 1:
                        Console.WriteLine("The sky is blue");
                        Console.Read();
                        break;
                    case 2:
                        Console.WriteLine("red roses");
                        Console.Read();
                        break;
                    case 3:
                        Console.WriteLine("white clouds");
                        Console.Read();
                        break;
                    case 4:
                        Console.WriteLine("black chair");
                        Console.Read();
                        break;
                    case 5:
                        Console.WriteLine("leather comes from cows");
                        Console.Read();
                        break;
                    case 6:
                        Console.WriteLine("wood is usually brown");
                        Console.Read();
                        break;
                    case 7:
                        Console.WriteLine("there are 60 minutes in one hour");
                        Console.Read();
                        break;
                    case 8:
                        Console.WriteLine("there are 50 states");
                        Console.Read();
                        break;
                    case 9:
                        Console.WriteLine("metal is silver");
                        Console.Read();
                        break;
                    case 10:
                        Console.WriteLine("water is transparent");
                        Console.Read();
                        break;
                }
            }
            Console.Read();
                //else:
                  //  Console.WriteLine("Error");
                    





            
        


        }
    }
}
