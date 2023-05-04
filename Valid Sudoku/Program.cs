//LeetCode 36
//Determine if a 9 x 9 Sudoku board is valid.
static bool IsValidSudoku(char[][] board)
{
    var rows = new Dictionary<int, HashSet<char>>();
    var cols = new Dictionary<int, HashSet<char>>();

    // create dictionary for each 3x3 square, keys represents the index of the square
    var squares = new Dictionary<(int, int), HashSet<char>>();

    for (var i = 0; i < 9; i++)
    {
        rows[i] = new HashSet<char>();
        for (var j = 0; j < 9; j++)
        {
            if (board[i][j] == '.') continue;

            if (!cols.ContainsKey(j)) cols[j] = new HashSet<char>();

            
            if (!squares.ContainsKey((i / 3, j / 3))) squares[(i / 3, j / 3)] = new HashSet<char>();

            if (rows[i].Contains(board[i][j]) 
                || cols[j].Contains(board[i][j]) 
                || squares[(i/3, j / 3)].Contains(board[i][j]))
            {
                return false;
            }

            rows[i].Add(board[i][j]);
            cols[j].Add(board[i][j]);
            squares[(i / 3, j / 3)].Add(board[i][j]);
        }   
    }

    return true;
}


IsValidSudoku(new char[][] {
    new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
    new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
    new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
    new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
    new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
    new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
    new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
    new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
    new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
});