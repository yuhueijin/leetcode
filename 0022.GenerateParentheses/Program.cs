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
        if (n == 1)
        {
            results.Add("()");
            return results;
        }

        for (int i = 1; i < n; i++)
        {
            var items = GenerateParenthesis(n - i);
            var subs = GenerateParenthesis(i);
            foreach (var item in items)
            {
                if (i == 1)
                {
                    var result = $"({item})";
                    if (!results.Contains(result))
                    {
                        results.Add(result);
                    }
                }
                foreach (var sub in subs)
                {
                    var target = $"{sub}{item}";
                    if (!results.Contains(target))
                    {
                        results.Add(target);
                    }
                    target = $"{item}{sub}";
                    if (!results.Contains(target))
                    {
                        results.Add(target);
                    }
                }
            }
        }

        return results;
    }
}