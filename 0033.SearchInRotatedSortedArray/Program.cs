// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var nums = new int[] { 3, 1 };
var target = 1;
var solution = new Solution();
var result = solution.Search(nums, target);
Console.WriteLine(result);

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var start = 0;
        var end = nums.Length - 1;
        while (start <= end)
        {
            var mid = (start + end) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[start] <= nums[mid])
            {
                if (target >= nums[start] && target < nums[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            else
            {
                if (target > nums[mid] && target <= nums[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }

            }

        }
        return -1;
    }
}