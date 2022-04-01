// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var matrix = new int[3][];
matrix[0] = new int[] { 1, 2, 3 };
matrix[1] = new int[] { 4, 5, 6 };
matrix[2] = new int[] { 7, 8, 9 };
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
        var n = matrix.Length;
        for (int y = 0; y < (n + 1) / 2; y++)
        {
            for (int x = 0; x < n / 2; x++)
            {
                var temp = matrix[n - 1 - x][y];
                matrix[n - 1 - x][y] = matrix[n - 1 - y][n - 1 - x];
                matrix[n - 1 - y][n - 1 - x] = matrix[x][n - 1 - y];
                matrix[x][n - 1 - y] = matrix[y][x];
                matrix[y][x] = temp;
            }
        }
    }
}