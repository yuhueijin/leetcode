// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var strs = new string[] { };
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
            var charArray = item.ToArray();
            Array.Sort(charArray);
            var target = new string(charArray);
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