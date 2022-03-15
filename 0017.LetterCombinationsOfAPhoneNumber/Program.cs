// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var digits = "23";
var solution = new Solution();
var result = solution.LetterCombinations(digits);
foreach (var item in result)
{
    Console.Write($"{item},");
}

public class Solution
{
    public IList<string> LetterCombinations(string digits)
    {
        var letters = new List<List<string>>();
        letters.Add(new List<string> { "a", "b", "c" });
        letters.Add(new List<string> { "d", "e", "f" });
        letters.Add(new List<string> { "g", "h", "i" });
        letters.Add(new List<string> { "j", "k", "l" });
        letters.Add(new List<string> { "m", "n", "o" });
        letters.Add(new List<string> { "p", "q", "r", "s" });
        letters.Add(new List<string> { "t", "u", "v" });
        letters.Add(new List<string> { "w", "x", "y", "z" });

        var result = new List<string>();
        foreach (var item in digits)
        {
            var index = (int)char.GetNumericValue(item) - 2;
            var target = letters[index];
            if (!result.Any())
            {
                result.AddRange(target);
                continue;
            }
            var count = result.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < target.Count; j++)
                {
                    result.Add(result[i] + target[j]);
                }
            }
            result.RemoveRange(0, count);
        }

        return result;
    }
}