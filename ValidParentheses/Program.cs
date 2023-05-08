//LeetCode 20
//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
static bool IsValid(string s)
{
    var stack = new Stack<char>();

    //keys are closing parentheses
    Dictionary<char, char> closeToOpen = new()
    {
        [')'] = '(',
        [']'] = '[',
        ['}'] = '{'
    };

    foreach (var item in s)
    {
        if (!closeToOpen.ContainsKey(item))
        {
            //add opening parentheses to stack
            stack.Push(item);
        }
        //Pop the opening character if it is closed 
        else if (stack.Count == 0 || stack.Pop() != closeToOpen[item])
        {
            return false;
        }
    }

    return stack.Count == 0;
}