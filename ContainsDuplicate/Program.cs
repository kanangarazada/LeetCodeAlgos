//LeetCode 217
//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
static bool ContainsDuplicate(int[] nums)
{
    HashSet<int> set = new HashSet<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (set.Contains(nums[i])) return true;
        set.Add(nums[i]);
    }

    return false;
}