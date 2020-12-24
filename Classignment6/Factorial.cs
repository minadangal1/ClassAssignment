using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class Factorial
    {
        public static void fac(int n)
        {

            int f = 1;
            for (int i = 1; i <= n; i++)
            {


                f = f * i;
                
            }

            Console.WriteLine("factorial of a ." + n + "=" + f);

        }
    }
}
