static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> prevMap = new ();

	int diff = 0;

	for (int i = 0; i < nums.Length; i++)
	{
		diff = target - nums[i];

		if(prevMap.ContainsKey(diff))
		{
			return new int[] { prevMap[diff], i };
		}

		prevMap[nums[i]] = i;
	}
	return new int[] { 0, 0};
}
