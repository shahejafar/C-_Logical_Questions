using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Logical_Questions
{
    public class SwapNumberWithoutUsingThirdVar
    {
        public void SwapNumber(int a, int b)
        {

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(" The Value Of A is : "+a+ " \n The Value Of B is : "+b);
            

        }
        


        

    }
}
