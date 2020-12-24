using System;

namespace Classignment6
{
    class Program
    {
        public static void Main(string[] args)
        {
            //   // Fib(15);

            int n = 15;

            //for(int i=1;i<n;i++)
            //   Console.WriteLine(Fib(15));
            //   static int Fib(int n)
            re("123");
            // Palindrome.palindrome(121);
            // Palindrome.palindrome(  123 );
            // Factorial.fac(6);
            // Armstrong a = new Armstrong();
            // a.armstrong(371);
            // a.armstrong(342);

            // Swap.swap(5,10);
            //  Reverse.reverse(34);
            // TriamglePartten.partten();
            TriamglePartten.patt();
        }
        static int Fib(int n)
        {

            int n1 = 0;
            int n2 = 1;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                result = n1 + n2;
                n1 = n2;
                n2 = result;
                 Console.WriteLine(result);
            }
            return result;
        }
        static void re(string n)
        {
            string result = n;
            string temp = "";
            int i;
            
            for( i = n.Length- 1; i >= 0; i--)
            {
                
                Console.WriteLine(i);
            }
            
            
            

            
        }







    }
       
        
    }


    
    




    



    