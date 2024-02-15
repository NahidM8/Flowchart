using System;
internal class Program
{
    static void Main(string[] args)
    {
        int x = 554;
        if (x>=100 && x<1000)
        {
            int a = x % 10;
            int b = (x / 10)%10;
            int c = x / 100;

            Console.WriteLine(a*b*c);

        }
    }
}
