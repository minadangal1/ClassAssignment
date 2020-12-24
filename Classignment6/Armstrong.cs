using System;
using System.Collections.Generic;
using System.Text;

namespace Classignment6
{
    class Armstrong
    {
       
        
        public void armstrong(int number)
        {
            int reminder;
            int temp= number;
            int result = 0;
            while (number > 0)
            {
                reminder = number % 10;
                result = result + reminder * reminder * reminder;
                number = number / 10;
            }
            if (result==temp)
            {
                Console.WriteLine(result+".is armstrong");
            }
            else
            {
                Console.WriteLine(result+".is not armstrong");
            }
        }

    }
}
