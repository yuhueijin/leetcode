// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var n = 10;
var solution = new Solution();
var result = solution.CountAndSay(n);
Console.WriteLine(result);

public class Solution
{
    public string CountAndSay(int n)
    {
        var result = "1";
        for (int i = 1; i < n; i++)
        {
            result = CountAndSay(result);
        }
        return result;
    }
    private string CountAndSay(string input)
    {
        var result = string.Empty;
        var element = input[0];
        var count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == element)
            {
                count++;
            }
            else
            {
                result += $"{count}{element}";
                count = 1;
                element = input[i];
            }
        }

        result += $"{count}{element}";
        return result;
    }
}