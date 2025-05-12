using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Questions
{
    internal class CharToInt_SmallToCapitl
    {

        public void CarToIntSmallToCap()
        {
            char charectorToInt = 'S';

            int IntNum = Convert.ToInt32(charectorToInt);

            Console.WriteLine(IntNum);

            string name = "shahejafar";

            Console.WriteLine(name.ToUpper());



            string[] arr = { "Shahejafar", "rushi", "GaNa", "MiLIND", "RUSHI" };

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = arr[i].ToLower();
            }

            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }


        }
    }
}
