using System;

namespace practicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st num : ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd num : ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int swap = 0;
            //swap
            swap = n1;
            n1 = n2;
            n2=swap;

            Console.WriteLine("Enter 1st num = " + n1);
            Console.WriteLine("Enter 2nd num = " + n2);

            Console.ReadKey();
        }
    }
}
