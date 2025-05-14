using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class Capital_FirstWordOf_EachString
    {

        public void CapitalFirstWord()
        {
            string str = "shahejafar kamal shaikh";

            string[] word=str.Split(' ');

            for(int i=0; i<word.Length; i++)
               
            {
                if (!string.IsNullOrEmpty(word[i]))
                {
                    word[i] = char.ToUpper(word[i][0]) + word[i].Substring(1).ToLower();

                }
            }
            Console.WriteLine(string.Join(" ",word));
        }
    }
}
