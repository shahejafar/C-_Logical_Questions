using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    public class Armstrong_Number
    {
        public void Armstrong(int num)
        {
            int temp = num;
            int r;
            int sum = 0;
            while (num > 0)
            {
                r = num % 10;
                sum = sum + (r * r * r);
                num =num/ 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("Given Number {0} is Armstrong ",temp);
            }
            else
            {
                Console.WriteLine("Given Number {0} is Not Armstrong ", temp);

            }
        }
    }
}
