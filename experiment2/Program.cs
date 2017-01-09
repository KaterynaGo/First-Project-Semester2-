using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace experiment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string phone = "12345679k";
            char[] numArray = phone.ToCharArray();
            for (int i = 0; i < phone.Length; i++)
            {
                Console.Write(numArray[i]);

                if(char.IsDigit(numArray[i]))
                {
                    Console.WriteLine(": its char");
                }
                else
                {
                    Console.WriteLine(": its smth else");
                }
            }
        }
    }
}
