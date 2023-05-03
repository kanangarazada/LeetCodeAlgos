//LeetCode 1
//Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
using System;

static int[] TwoSum(int[] nums, int target)
{
    //keys are array's elements and values are indices of the elements in array
    Dictionary<int, int> prevMap = new ();

	int diff = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		//check the difference between element of array and target, if it is on the dictionary's key return the indices 
		diff = target - nums[i];

		if(prevMap.ContainsKey(diff))
		{
			return new int[] { prevMap[diff], i };
		}

		prevMap[nums[i]] = i;
	}
	return new int[] { 0, 0};
}
