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
        for (int i = 0; i < board.Length; i++)
        {
            var row = new List<char>();
            var column = new List<char>();
            for (int j = 0; j < board[i].Length; j++)
            {
                row.Add(board[i][j]);
                column.Add(board[j][i]);
            }
            if (!IsValidSudoku(row.ToArray()))
            {
                return false;
            }
            if (!IsValidSudoku(column.ToArray()))
            {
                return false;
            }
        }

        var firstSquare = new List<char>();
        var secondSquare = new List<char>();
        var thirdSquare = new List<char>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (j < 3)
                {
                    firstSquare.Add(board[i][j]);
                }
                else if (j < 6)
                {
                    secondSquare.Add(board[i][j]);
                }
                else
                {
                    thirdSquare.Add(board[i][j]);
                }
            }
            if (i == 2 || i == 5 || i == 8)
            {
                if (!IsValidSudoku(firstSquare.ToArray()) || !IsValidSudoku(secondSquare.ToArray())
                || !IsValidSudoku(thirdSquare.ToArray()))
                {
                    return false;
                }
                firstSquare.Clear();
                secondSquare.Clear();
                thirdSquare.Clear();
            }
        }
        return true;
    }
    private bool IsValidSudoku(char[] line)
    {
        var set = new HashSet<char>();
        for (int i = 0; i < line.Length; i++)
        {
            if (line[i] == '.')
            {
                continue;
            }
            if (set.Contains(line[i]))
            {
                return false;
            }
            set.Add(line[i]);
        }
        return true;
    }
}