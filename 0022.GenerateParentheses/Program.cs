// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var n = 4;
var solution = new Solution();
var result = solution.GenerateParenthesis(n);
foreach (var item in result)
{
    Console.Write($"{item},");
}

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var results = new List<string>();
        Backtrack(results, "", 0, 0, n);
        return results;
    }
    private void Backtrack(List<string> results, string result, int start, int end, int max)
    {
        if (result.Length == max * 2)
        {
            results.Add(result);
            return;
        }

        if (start < max)
        {
            result += "(";
            Backtrack(results, result, start + 1, end, max);
            result = result.Substring(0, result.Length - 1);
        }

        if (end < start)
        {
            result += ")";
            Backtrack(results, result, start, end + 1, max);
            result = result.Substring(0, result.Length - 1);
        }
    }
}