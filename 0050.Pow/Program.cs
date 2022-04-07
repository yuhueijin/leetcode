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
        var pow = n;
        if (pow < 0)
        {
            x = 1 / x;
            pow = -pow;
        }

        return fastPow(x, pow);
    }

    private double fastPow(double x, int pow)
    {
        if (pow == 0)
        {
            return 1.0;
        }
        var half = fastPow(x, pow / 2);
        if (pow % 2 == 0)
        {
            return half * half;
        }
        else
        {
            return half * half * x;
        }
    }
}