using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3, s1, s2;
            a1 = int.Parse(Console.ReadLine());
            a2 = int.Parse(Console.ReadLine());
            a3 = int.Parse(Console.ReadLine());
            s1 = a3 - a2;
            s2 = a2 - a1;
            if (s1 == s2)
                Console.WriteLine("yes");
            else
                Console.WriteLine("NO");
            Console.ReadLine();
        }
    }
}
