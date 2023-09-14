using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Loops__While_and_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is now the normal while loop");
            int  index = 6;

            while (index <= 5) {
                Console.WriteLine(index);
                index++;


            }

            Console.WriteLine("This is now the DO While loop");
            int index2 = 6;
            do
            {

                Console.Write(index2);
                index2++;

            }
            while (index2 <= 5);

            //freeze 
            Console.Read();


              



        }
    }
}
