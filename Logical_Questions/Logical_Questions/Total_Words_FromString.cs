using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class Total_Words_FromString
    {

        public void Total_Words()
        {
            string str = "Shahejafar kamal shaikh";
            string[] word= str.Split(' ');
            int count = 0;

            foreach (string word2 in word)
            {
                count++;
            }
            Console.WriteLine("Total Words : "+count);
        }
    }
}
