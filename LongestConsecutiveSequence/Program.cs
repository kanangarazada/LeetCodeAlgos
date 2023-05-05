//LeetCode 128
//Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

static int LongestConsecutive(int[] nums)
{
    var set = new HashSet<int>(nums);
    int longest = 0;

    foreach (var n in set)
    {
        //check if it is the start of consecutive set
        if (!set.Contains(n - 1))
        {
            int length = 0;
            while (set.Contains(n + length))
            {
                length++;
                longest = Math.Max(longest, length);
            }
        }
    }
    return longest;
}
