using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class FibonachiSeries
    {

        public void FiboSeries(int num) 
        {

            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.Write(num1 +" " +num2 );

            for(int i =2; i < num; i++)
            {
                num3 = num1 + num2;
                Console.Write(" "+num3);
                num1 = num2;
                num2 = num3;
            }
            
        }
    }
}
