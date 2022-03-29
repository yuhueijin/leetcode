// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var board = new char[9][];
board[0] = new char[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' };
board[1] = new char[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' };
board[2] = new char[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' };
board[3] = new char[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' };
board[4] = new char[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' };
board[5] = new char[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' };
board[6] = new char[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' };
board[7] = new char[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' };
board[8] = new char[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' };
var solution = new Solution();
var result = solution.IsValidSudoku(board);
Console.WriteLine(result);

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var n = 9;
        var rows = new List<HashSet<char>>();
        var columns = new List<HashSet<char>>();
        var boxes = new List<HashSet<char>>();
        for (int i = 0; i < n; i++)
        {
            rows.Add(new HashSet<char>());
            columns.Add(new HashSet<char>());
            boxes.Add(new HashSet<char>());
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (board[i][j] == '.')
                {
                    continue;
                }

                if (rows[j].Contains(board[i][j]))
                {
                    return false;
                }
                rows[j].Add(board[i][j]);

                if (columns[i].Contains(board[i][j]))
                {
                    return false;
                }
                columns[i].Add(board[i][j]);

                var index = (i / 3) * 3 + j / 3;
                if (boxes[index].Contains(board[i][j]))
                {
                    return false;
                }
                boxes[index].Add(board[i][j]);
            }
        }
        return true;
    }
}