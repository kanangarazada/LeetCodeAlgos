//LeetCode 84
//Given an array of integers heights representing the histogram's bar height where the width of each bar is 1, return the area of the largest rectangle in the histogram.
static int LargestRectangleArea(int[] heights)
{
    int maxArea = 0;

    Stack<(int index,int height)> stack = new ();

    for (int i = 0; i < heights.Length; i++)
    {
        var start = i;

        //if the current bar is shorter than previous, calculate the maximum area because we can not expand it anymore 
        while (stack.Count > 0 && stack.Peek().height > heights[i])
        {
            var pair = stack.Pop();

            maxArea = Math.Max(maxArea, pair.height * (i - pair.index));

            start = pair.index;
        }

        //index of the bar is how much we can expand it to the left and if the current bar is shorter than previous it means we can expand it to the left 
        stack.Push((start, heights[i]));
    }

    //calculate the rest rectangle 
    foreach(var pair in stack)
    {
        maxArea = Math.Max(maxArea, pair.height * (heights.Length - pair.index));
    }

    return maxArea;
}