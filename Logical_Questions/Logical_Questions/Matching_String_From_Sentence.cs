using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class Matching_String_From_Sentence
    {

        public void MatchingString()
        {
            string str = "Shahejafar Shaikh Is Member Of Shaikh Family";

            string[] arr=str.Split(' ');

           for(int i=0; i<arr.Length; i++)
            {
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        Console.Write(arr[i]+" ");
                    }
                }
            }
        }
    }
}
