
using System;

namespace BreakContinueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, num;
            Console.Write("Enter a number greater than 5: ");
            num = Convert.ToInt32(Console.ReadLine());
            //num = Convert.ToInt32(args[0]);
            Console.WriteLine("---Break stops iteration @ 5---");
            i = 0;
            while (i < num)
            {
                if (i == 5)
                {
                    i++;
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("--Continue skips iteration @ 5--");
            while (i < num)
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
