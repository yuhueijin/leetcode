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
        if (nums.Length == 1)
        {
            if (target == nums[0])
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (target < nums[i])
            {
                break;
            }
            if (target == nums[i])
            {
                return i;
            }
            if (target == nums[i + 1])
            {
                return i + 1;
            }
            if (nums[i] > nums[i + 1])
            {
                break;
            }
        }

        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (target > nums[i])
            {
                break;
            }
            if (target == nums[i])
            {
                return i;
            }
            if (target == nums[i - 1])
            {
                return i - 1;
            }
            if (nums[i] < nums[i - 1])
            {
                break;
            }

        }
        return -1;
    }
}