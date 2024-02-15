using System;
internal class Program
{
    static void Main(string[] args)
    {
        int x=Convert.ToInt32(Console.ReadLine());
        int y=Convert.ToInt32(Console.ReadLine());
        int z=Convert.ToInt32(Console.ReadLine());
        int sum =0;
        if (x>10 && x<100)
        {
            sum += x;
        }
        if (y>10 && y<100)
        {
            sum += y;
        }
        if(z>10 && z<100)
        {
            sum += z;
        }
        Console.WriteLine(sum);
    }
}
