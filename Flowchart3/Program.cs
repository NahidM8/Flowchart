using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp=Convert.ToInt32(Console.ReadLine());
            if (temp == 15)
            {
                Console.WriteLine("15 derecedir");
            }
            else if (temp>15)
            {
                Console.WriteLine("Hava istidir");
            }
            else
            {
                Console.WriteLine("Hava soyuqdur");
            }
        }
    }
