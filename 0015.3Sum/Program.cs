// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { -1, 0, 1, 2, -1, -4 };
var solution = new Solution();
var result = solution.ThreeSum(nums);
foreach (var item in result)
{
    Console.WriteLine(string.Join(",", item.ToArray()));
}

public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var candidates = new List<List<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    var candidate = new List<int> { nums[i], nums[j], nums[k] };
                    candidates.Add(candidate);
                }
            }
        }

        var result = new List<IList<int>>();
        foreach (var candidate in candidates)
        {
            if (candidate[0] + candidate[1] + candidate[2] == 0)
            {
                result.Add(candidate);
            }
        }
        return result;

    }
}