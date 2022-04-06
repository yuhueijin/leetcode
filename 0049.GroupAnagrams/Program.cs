// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var strs = new string[] { "bdddddddddd", "bbbbbbbbbbc" };
var solution = new Solution();
var result = solution.GroupAnagrams(strs);


public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new List<IList<string>>();
        var dict = new Dictionary<string, List<string>>();
        foreach (var item in strs)
        {
            var charCount = new int[26];
            foreach (var charItem in item)
            {
                charCount[charItem - 'a']++;
            }
            var target = string.Join("#", charCount);
            if (dict.ContainsKey(target))
            {
                dict[target].Add(item);
            }
            else
            {
                dict.Add(target, new List<string>() { item });
            }
        }
        foreach (var item in dict)
        {
            result.Add(item.Value);
        }
        return result;
    }
}