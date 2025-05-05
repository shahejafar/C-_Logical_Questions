using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class MaxNumberFromArray
    {

        public void MaxNumber()
        {
            int[] arr = { 12, 32, 45, 65, 78, 54, 12, 65 };

            int max = arr[0];

            Console.Write("Given Array : ");

            foreach (int i in arr)
            {
                Console.Write(i+" ");
            }


            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine("\n");

            Console.WriteLine("Greates Number From Array : "+ max);
        }
    }
}
