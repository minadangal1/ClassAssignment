using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class TriamglePartten
    {





        public static void partten()
        {
            char a = 'A';
            int x = 1;//print control
            int n = 5;//size
            for (int i = 1; i <= n; i++) //outer loop
            {
                for (int j = n - 1; j >= i; j--)//inner space loop(colum)
                {
                    Console.Write(" ");
                }

                for(int k = 1; k <= x; k++)//print loop
                {
                    Console.Write(a++);
                }
                x += 2;
               
               
                Console.Write("\n");
                a = 'A';
            }


        }
        public static void patt()
        {
            int i, j, k, l = 0;
            int n = 5;
            char cha = 'A';
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j <= 5; j--)
                {
                    Console.WriteLine(" ");
                }
                for (k = 1; k < i; k++)
                {
                    Console.WriteLine(cha++);
                }
                cha--;
                for (l = 1; l < i; l++)
                {
                    Console.WriteLine(--cha);
                        
                        
                }
                Console.WriteLine("\n");
                cha = 'A';

            }

        }
    }
}
