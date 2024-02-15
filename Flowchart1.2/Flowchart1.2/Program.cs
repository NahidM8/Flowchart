using System;
internal class Program
{
    static void Main(string[] args)
    {
        int month = 1;
        if (month>=1 && month<=12)
        {
            if (month>=3 && month<=5)
            {
                Console.WriteLine("yaz");
            }
            else if (month >= 6 && month <= 8)
            {
                Console.WriteLine("yay");
            }
            else if (month >= 9 && month <= 11)
            {
                Console.WriteLine("payiz");
            }
            else
            {
                Console.WriteLine("qish");
            }
        }

    }
}
