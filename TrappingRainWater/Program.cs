//LeetCode 42
//Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.
static int Trap(int[] height)
{
    var (left, right) = (0, height.Length - 1);
    //keep track of maximum values of each side for calculating trapping watter
    var (leftMax, rightMax) = (height[left], height[right]);
    int waterVolume = 0;

    while (left < right)
    {
        if (leftMax < rightMax)
        {
            left++;
            leftMax = Math.Max(leftMax, height[left]);
            waterVolume += leftMax - height[left];
        }
        else
        {
            right--;
            rightMax = Math.Max(rightMax, height[right]);
            waterVolume += rightMax - height[right];
        }
    }
    return waterVolume;
}

Trap(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });