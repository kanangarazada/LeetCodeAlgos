//LeetCode 238
//Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
static int[] ProductExceptSelf(int[] nums)
{
    //product of previous elements 
    int prefix = 1;
    var resultArray = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        resultArray[i] = prefix;
        prefix *= nums[i];
    }

    //product of next elements multiplied by product of previous elements
    int postfix = 1;

    for (int i = nums.Length - 1; i >= 0; i--)
    {
        resultArray[i] *= postfix;
        postfix *= nums[i];
    }

    return resultArray;
}
