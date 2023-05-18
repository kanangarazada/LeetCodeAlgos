//LeetCode 11
//You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).
//Find two lines that together with the x-axis form a container, such that the container contains the most water.
static int MaxArea(int[] height)
{
    int result = 0;

    int left = 0;
    int right = height.Length - 1;

    while (left < right)
    {
        //calculate the area 
        result = Math.Max(result, (right - left) * Math.Min(height[left], height[right]));

        if (height[left] <= height[right])
        {
            left++;
        }
        else
        {
            right--;
        }

    }

    return result;
}