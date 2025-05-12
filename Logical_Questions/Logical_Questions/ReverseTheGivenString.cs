using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class ReverseTheGivenString
    {

        public void ReverseString()
        {
            string str = "shahejafar";
            string rev= string.Empty;

            for(int i= str.Length-1; i >= 0; i--)
            {
                rev = rev + str[i];
            }
            Console.WriteLine(rev);
        }
    }
}
