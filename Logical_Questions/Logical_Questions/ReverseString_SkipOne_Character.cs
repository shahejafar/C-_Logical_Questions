using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class ReverseString_SkipOne_Character
    {

        public void ReverseStringSkipCharactor()
        {
            string str = "shahejafar";
            string result = string.Empty;
            bool flag = false;
            for(int i =str.Length - 1; i >= 0; i--)
            {
                if (flag == false)
                {
                    result += str[i];
                    flag = true;
                }
                else
                {
                   flag = false;
                }
            }
            Console.WriteLine(result);
        }
    }
}
