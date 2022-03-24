// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var dividend = 10;
var divisor = -3;
var solution = new Solution();
var result = solution.Divide(dividend, divisor);
Console.WriteLine(result);

public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        var count = 0;
        var minus = false;
        var positive = true;
        if (dividend < 0)
        {
            positive = false;
        }
        if (dividend > 0 && divisor < 0)
        {
            minus = true;
        }
        if (dividend < 0 && divisor > 0)
        {
            minus = true;
        }
        while (true)
        {
            if (positive && dividend < 0)
            {
                break;
            }
            if (!positive && dividend > 0)
            {
                break;
            }

            if (minus)
            {
                dividend += divisor;
                count--;
            }
            else
            {
                dividend -= divisor;
                count++;
            }
        }
        return count > 0 ? --count : ++count;
    }
}