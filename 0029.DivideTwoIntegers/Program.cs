// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var dividend = 2147483647;
var divisor = 2;
var solution = new Solution();
var result = solution.Divide(dividend, divisor);
Console.WriteLine(result);

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        if (dividend == int.MinValue && divisor == -1)
        {
            return int.MaxValue;
        }

        var negatives = 2;
        if (dividend > 0)
        {
            negatives--;
            dividend = -dividend;
        }
        if (divisor > 0)
        {
            negatives--;
            divisor = -divisor;
        }
        var quotient = 0;
        while (divisor >= dividend)
        {
            var powerOfTwo = -1;
            var value = divisor;
            while (int.MinValue / 2 <= value && dividend <= value + value)
            {
                value = value + value;
                powerOfTwo += powerOfTwo;
            }

            quotient += powerOfTwo;
            dividend -= value;
        }
        if (negatives != 1)
        {
            quotient = -quotient;
        }
        return quotient;
    }
}