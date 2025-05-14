using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logical_Questions
{
    internal class Reverse_EachCharacter_FromString
    {
        public void ReverseString()
        {
            string str = "Shahejafar Shaikh";
            string[] input= str.Split(' ');
            string result = "";
          
            foreach (string words in input)
            {
                string revers = "";
                for(int i =words.Length-1; i>=0; i--)
                {             
                        revers += words[i];                         
                }
                result += revers + " ";
            }
            Console.WriteLine(result);
        }
    }
}
