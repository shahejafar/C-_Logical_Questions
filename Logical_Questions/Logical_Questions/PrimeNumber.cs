using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    public class PrimeNumber
    {
        public void PrimeNum(int num)
        {
            bool flag = false;

            for(int i= 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = true;
                    break;
                    
                }

            }
            if(flag== false)
            {
                Console.WriteLine("Number {0} Is Prime Number. ", num);
            }
            else
            {
                Console.WriteLine("Number {0} Is Not Prime Number. ", num);
            }
        }

    }
}
