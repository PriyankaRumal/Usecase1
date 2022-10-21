using System;

namespace UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int value=random.Next(0,2);
            if(value==0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }
    }
}
