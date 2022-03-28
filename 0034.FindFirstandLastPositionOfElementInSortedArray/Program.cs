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
        var pos = -1;
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
                pos = mid;
                break;
            }
        }
        if (pos == -1)
        {
            return new int[] { -1, -1 };
        }
        var right = pos;
        var left = pos;
        while (right >= 0 && nums[right] == target)
        {
            right--;
        }
        while (left < nums.Length && nums[left] == target)
        {
            left++;
        }
        return new int[] { ++right, --left };
    }
}