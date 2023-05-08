//LeetCode 155
//Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
public class MinStack
{
    private Stack<int> stack;
    private Stack<int> minStack;

    public MinStack()
    {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }

    public void Push(int val)
    {
        stack.Push(val);
        //add minimum value for each element 
        int min = Math.Min(val, minStack.Count != 0 ? minStack.Peek() : val);
        minStack.Push(min);
    }

    public void Pop()
    {
        stack.Pop();
        minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}
