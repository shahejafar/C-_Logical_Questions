using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    public class Palindrome_Number
    {
        public void Palindrome(int num)
        {
            int temp = num;
            int r;
            int sum = 0;

           while(num>0)
            {
                r = num % 10;  
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("Given Number {0} is Palindrome ",temp);
            }
            else
            {
                Console.WriteLine("Given Number {0} is \"Not\" Palindrome ", temp);

            }


        }
    }
}
