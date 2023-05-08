//LeetCode 150
//You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.
//Evaluate the expression. Return an integer that represents the value of the expression.
static int EvalRPN(string[] tokens)
{
    Stack<int> stack = new();

    foreach (var token in tokens)
    {
        //pop last two element in the stack, make operation and push result to the stack
        switch (token)
        {
            case "+": 
                stack.Push(stack.Pop() + stack.Pop());
                break;
            case "-":
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b-a);
                break;
            case "*":
                stack.Push(stack.Pop() * stack.Pop());
                break;
            case "/":
                int c = stack.Pop();
                int d = stack.Pop();
                stack.Push(d/c);
                break;
            default: 
                stack.Push(Convert.ToInt32(token)); 
                break;
        }
    }

    return stack.Pop();
}