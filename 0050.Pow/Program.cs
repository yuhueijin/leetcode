// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var x = 2.00000;
var n = -2;
var solution = new Solution();
var result = solution.MyPow(x, n);
Console.WriteLine(result);

public class Solution
{
    public double MyPow(double x, int n)
    {
        var count = 0;
        double result = 1;
        while ((n > 0 && count < n) || (n < 0 && count > n))
        {
            if (n > 0)
            {
                result = result * x;
                count++;
            }
            else
            {
                result = result / x;
                count--;
            }
        }
        return result;
    }
}