using System;
class number
    {
        static void Main(string[] args)
        {
            int number = 400;

            int revereNumber = 0;
            int remainder = 0;
            Console.WriteLine("Number before reverse = " + number);
            while(number > 0)
            {
                remainder = number % 10;
                number = number / 10;
                revereNumber = revereNumber * 10 + remainder;
            }
            Console.WriteLine("Number after reverse  = "+ revereNumber);
        }
    }
