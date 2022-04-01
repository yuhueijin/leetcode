// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var matrix = new int[3][];
matrix[0] = new int[] { 1, 2, 3, 4 };
matrix[1] = new int[] { 5, 6, 7, 8 };
matrix[2] = new int[] { 9, 10, 11, 12 };
var solution = new Solution();
solution.Rotate(matrix);

foreach (var item in matrix)
{
    Console.WriteLine(string.Join(",", item));
}

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        var set = new HashSet<string>();
        var n = matrix.Length;
        for (int y = 0; y < n; y++)
        {
            for (int x = 0; x < n; x++)
            {
                if (set.Contains($"{x},{y}"))
                {
                    continue;
                }

                var sourceX = x;
                var sourceY = y;
                var targetX = x + 1;
                var targetY = y + 1;
                var sourceElement = matrix[y][x];
                var targetElement = 0;
                var count = 0;
                while (count <= 4)
                {
                    targetX = n - 1 - sourceY;
                    targetY = sourceX;
                    targetElement = matrix[targetY][targetX];
                    matrix[targetY][targetX] = sourceElement;
                    sourceElement = targetElement;
                    sourceX = targetX;
                    sourceY = targetY;
                    count++;
                    set.Add($"{targetX},{targetY}");
                }
            }
        }
    }
}