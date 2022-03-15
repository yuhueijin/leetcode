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
    private Dictionary<char, string> letters = new Dictionary<char, string> {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" },
            { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" },
            { '8', "tuv" }, { '9', "wxyz" }};

    public IList<string> LetterCombinations(string digits)
    {
        if (string.IsNullOrEmpty(digits))
        {
            return new List<string>();
        }

        var result = new List<string>();
        LetterCombinations(digits, 0, result, "");
        return result;
    }

    private void LetterCombinations(string digits, int index, List<string> result, string line)
    {
        if (digits.Length == line.Length)
        {
            result.Add(line);
            return;
        }

        var possibleLetters = letters[digits[index]];
        foreach (var letter in possibleLetters)
        {
            line += letter;
            LetterCombinations(digits, index + 1, result, line);
            line = line.Remove(line.Length - 1);
        }
    }
}