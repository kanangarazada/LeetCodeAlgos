//LeetCode 15
//Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
static IList<IList<int>> ThreeSum(int[] nums)
{
    List<IList<int>> result = new();

    Array.Sort(nums);

    for (int i = 0; i < nums.Length; i++)
    {
        if (i > 0 && nums[i] == nums[i - 1]) continue;

        int left = i + 1;
        int right = nums.Length - 1;

        while (left < right)
        {
            if (nums[i] + nums[left] + nums[right] > 0)
            {
                right--;
            }
            else if (nums[i] + nums[left] + nums[right] < 0)
            {
                left++;
            }
            else
            {
                result.Add(new List<int> { nums[i], nums[left], nums[right] });
                left++;

                //skip duplicate numbers
                while (nums[left] == nums[left - 1] && left < right)
                {
                    left++;
                }
            }
        }
    }
    
    return result;
}