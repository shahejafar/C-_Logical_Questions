using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    public class Count_Total_Digit_In_Number
    {
        public void Total_Digit(int num)
        {
        
            int count = 0;
            while(num > 0) 
            {
                count++;
                num = num / 10;
               
            }
            Console.WriteLine("Total Digit In Given Number is :" +count);
        }
    }
}
