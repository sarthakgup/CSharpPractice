using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class ArrayMethodsCode
    {
        static void Main(string[] args)
        {
            int[] UserValues = new int[10];
            int n;

            for(int i = 0; i<UserValues.Length; i++)
            {
                Console.WriteLine("Enter number {0}", i+1);
                UserValues[i] = Convert.ToInt32(Console.ReadLine());
            }
            ReturnArrayOutliers(UserValues);
            Console.WriteLine("Enter another integer: ");
            n = Convert.ToInt32(Console.ReadLine());
            MultiplicationMethod(UserValues, n);
            Console.WriteLine("\nOk. After multiplying by {0}, your numbers are:", n);

            for (int x = 0; x<UserValues.Length; x++)
            {
                Console.WriteLine(Convert.ToString(UserValues[x]));
            }                    
            
            //Console.WriteLine(Convert.ToString(UserValues));
            Console.ReadLine();
        }

        //The method prints the highest and lowest values of an array.
        public static void ReturnArrayOutliers(int[] Array)
        {
            int lowest;
            int highest;
            lowest = Array[0];
            highest = Array[0];
            for(int x = 1; x<Array.Length; x++)
            {
                if(Array[x] < lowest)
                {
                    lowest = Array[x];
                }
                if(Array[x] > highest)
                {
                    highest = Array[x];
                }
                //lowest = Array[x-1];
            }
            Console.WriteLine("The lowest number is: {0}", lowest);
            Console.WriteLine("The highest number is: {0}", highest);
            Console.WriteLine("<press enter to continue>");
            Console.ReadLine();            
        }

        //The method below multiplies all the values by 'n' which is passed as a parameter.
        public static void MultiplicationMethod(int[] Array, int n)
        {
            for(int i = 0; i<Array.Length; i++)
            {
                Array[i] = Array[i] * n;
            }
        }
    }
}
