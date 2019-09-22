using System;

namespace self_dividing_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number:");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Enter the next number:");
            int j = int.Parse(Console.ReadLine());
            for (int num = i; num <= j; num++)
            {
                int selfDividing = 1;
                for (int temp = num; temp > 0; temp /= 10)
                {
                    int dig = temp % 10;
                    if (dig == 0 || num % dig != 0)
                    {
                        selfDividing = 0;
                        break;
                    }
                }
                if (selfDividing == 1)
                {
                    Console.Write("{0},",num);
                }
            }
        }
    }
}
