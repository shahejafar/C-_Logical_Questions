using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class EveryCharactorofString_InNewLine
    {

        public void StringNewLine()
        {
            string name = "Shahejafar";

            for(int i=0; i<name.Length; i++)
            {
                if (name[i] != ' ')
                {
                    Console.WriteLine(name[i]);
                }
            }
        }
    }
}
