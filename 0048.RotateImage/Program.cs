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
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                var temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n / 2; j++)
            {
                var temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - 1 - j];
                matrix[i][n - 1 - j] = temp;
            }
        }
    }
}