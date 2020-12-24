using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class Palindrome
    {
       public static void palindrome(int number)
        {

            
            int remineder, rev = 0;
            int temp = number;
            while (number > 0)
            {
               
                

                
                //Get the remainder by dividing the number with 10  
                remineder = number % 10; //ex:123%10 reminder=3 again numbr=12 and reminder=12%10=2 again reminder=1
                //multiply the sum with 10 and then add the remainder
                rev= (rev * 10) + remineder;//rev=0;so rev=0*10+3=3 again rev=3*10+2=32 again rev=32*10+1=321

                // dividing the number with 10 
                number = number / 10;//number=123/10=12 again 12/10=1 still number is >0 so number=1/10=0 now number =0 not a >0so stope the loop
            }
            if (temp == rev)
            {
                Console.WriteLine( temp+":Numberis Palindrome.") ;
            }
            else
            {
                Console.WriteLine(temp+":Numberis not Palindrome");
            }
            
        }
       public static void factorial(int n)
        {
            
            int f = 1;
            for (int i = 1; i <=n; i++)
            {
                
                
                   f  = f* i;
                  //  Console.WriteLine(f);
            }

            Console.WriteLine("factorial of a ."+n+"="+f);
            
        }
    }
    }

