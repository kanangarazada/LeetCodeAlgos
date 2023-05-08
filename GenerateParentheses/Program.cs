//LeetCode 22
//Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.
using System.Text;

static IList<string> GenerateParenthesis(int n)
{
    var result = new List<string>();
    var seq = new StringBuilder();

    //create fully nested parentheses first, then start to remove from end of the string and try every combination
    void backtrack(int open, int close)
    {
        if (seq.Length == n * 2)
        {
            result.Add(seq.ToString());
            return;
        }

        if (open < n)
        {
            seq.Append("(");
            backtrack(open + 1, close);
            seq.Remove(seq.Length - 1, 1);
        }
        if (close < open)
        {
            seq.Append(")");
            backtrack(open, close + 1);
            seq.Remove(seq.Length - 1, 1);
        }

    }

    backtrack(0, 0);

    return result;
}