using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, ctr, startingnumber, endingnumber;

            Console.WriteLine("We put the prime numbers within a range of numbers:");
            Console.Write("---------------------------------------------------");
            Console.WriteLine("");

         Console.Write("please,Input starting number of range: ");
          startingnumber = Convert.ToInt32(Console.ReadLine());
         Console.Write("please,Input ending number of range : ");
         endingnumber = Convert.ToInt32(Console.ReadLine());

            for (num = startingnumber; num <= endingnumber; num++)
            {
                ctr = 0;

                for (i = 2; i <= num/2 ; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            Console.WriteLine("");
        }

    }
    
}
