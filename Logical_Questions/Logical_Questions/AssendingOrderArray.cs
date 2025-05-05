using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class AssendingOrderArray
    {

        public void AssendingOrder()
        {
            int[] arr = { 1, 2, 4, 2, 4, 6, 8, 9, 3 };
            
                    
            for (int i  = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        
                    }
                }
            }


            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }

           
        }
    }
}
