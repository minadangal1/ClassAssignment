using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class Reverse
    {
        public static void reverse(int n)
        {
            int temp = n;
            char[] array = n.ToString().ToCharArray();
            
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
