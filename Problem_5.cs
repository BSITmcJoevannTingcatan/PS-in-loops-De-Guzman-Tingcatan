using System;

class SumOddDigits
{
    static void Main()
    {
        int num = 1234567;
        int sum = 0;
        while (num > 0)
        {
            int digit = num % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            num /= 10;
        }
        Console.WriteLine(sum);
    }
}
