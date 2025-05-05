using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class SecondHighestFromArray
    {
        public void SecondMax()
        {
            int[] arry = { 12, 32, 45, 65, 78, 54, 12, 65 };

            int max, secmax;
            max = secmax= arry[0];

            Console.Write("Given Array : ");

            foreach(int i in arry)
            {
                Console.Write(i+" ");   
            }
             
            for(int i = 0; i < arry.Length; i++)
            {
                if (arry[i] > max)
                {
                    secmax = max;
                    max = arry[i];
                  
                }
                else if (arry[i] > secmax)
                {
                    secmax = arry[i];
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("Second Max number from array is : "+ secmax);
        }

    }
}
