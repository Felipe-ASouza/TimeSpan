using System;

namespace Duracao
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromHours(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
        }
    }
}