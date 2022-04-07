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
        double response = 1;
        for (int i = 0; i < pow; i++)
        {
            response = response * x;
        }
        return response;
    }
}