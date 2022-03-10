// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { 0, 0, 0 };
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
        Array.Sort(nums);
        var result = new List<IList<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                continue;
            }
            else if (i == 0 || nums[i - 1] != nums[i])
            {
                result.AddRange(ThreeSum(nums, i));
            }
        }
        return result;
    }

    private IList<IList<int>> ThreeSum(int[] nums, int i)
    {
        var low = i + 1;
        var high = nums.Length - 1;
        var result = new List<IList<int>>();
        while (low < high)
        {
            if (nums[i] + nums[low] + nums[high] == 0)
            {
                result.Add(new List<int> { nums[i], nums[low], nums[high] });
                low++;
                high--;
                while (low < high && nums[low - 1] == nums[low])
                {
                    low++;
                }
            }
            else if (nums[i] + nums[low] + nums[high] > 0)
            {
                high--;
            }
            else
            {
                low++;
            }
        }
        return result;
    }
}