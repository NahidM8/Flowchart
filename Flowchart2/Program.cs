using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());
            if(n%2==0 && m%2==0)
            {
                Console.WriteLine(n + m);
            }
            else
            {
                Console.WriteLine("duzgun eded daxil et");
            }
        }
    }
