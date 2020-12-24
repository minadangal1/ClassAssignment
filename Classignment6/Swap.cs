using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class Swap
    {
     public static void swap(int a,int b)
        {
            Console.WriteLine("orginal number");
            Console.WriteLine("a=" +a);
            Console.WriteLine("b="+b);



            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("after swap number" + "\na=" + a + "\nb=" + b);
            Console.WriteLine(" a=" + a + "\n b=" + b);
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
