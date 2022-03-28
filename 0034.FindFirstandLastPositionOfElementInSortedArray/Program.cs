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
        var firstPos = findBound(nums, target, true);
        var secondPos = findBound(nums, target, false);
        return new int[] { firstPos, secondPos };
    }

    private int findBound(int[] nums, int target, bool isFirst)
    {
        var start = 0;
        var end = nums.Length - 1;

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
                if (isFirst)
                {
                    if (mid == start || nums[mid - 1] != target)
                    {
                        return mid;
                    }
                    end = mid - 1;
                }
                else
                {

                    if (mid == end || nums[mid + 1] != target)
                    {
                        return mid;
                    }
                    start = mid + 1;
                }
            }
        }

        return -1;
    }
}

