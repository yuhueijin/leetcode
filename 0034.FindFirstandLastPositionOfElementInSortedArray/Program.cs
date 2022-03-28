// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { 1 };
var target = 1;
var solution = new Solution();
var result = solution.SearchRange(nums, target);
foreach (var item in result)
{
    Console.Write($"{item},");
}

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;
        // find first
        var firstPos = -1;
        while (start <= end)
        {
            var mid = (start + end) / 2;
            if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                if (mid == start || nums[mid - 1] != target)
                {
                    firstPos = mid;
                }
                end = mid - 1;
            }
        }
        start = 0;
        end = nums.Length - 1;
        var secondPos = -1;
        while (start <= end)
        {
            var mid = (start + end) / 2;
            if (nums[mid] > target)
            {
                end = mid - 1;
            }
            else if (nums[mid] < target)
            {
                start = mid + 1;
            }
            else
            {
                if (mid == end || nums[mid + 1] != target)
                {
                    secondPos = mid;
                }
                start = mid + 1;
            }
        }
        return new int[] { firstPos, secondPos };
    }
}