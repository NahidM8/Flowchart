using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            if (n == 0)
            {
                Console.WriteLine("Duzgun eded daxil et");
            }
            else if (n % 2 == 1)
            {
                Console.WriteLine("Tekdir");
            }
            else
            {
                Console.WriteLine("Cutdur");
            }

        }
    }

