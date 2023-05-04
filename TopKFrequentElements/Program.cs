//LeetCode 347
//Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
static int[] TopKFrequent(int[] nums, int k)
{
    int[] resultArr = new int[k];

    //keys are array's elements and values are frequency of the element in array
    Dictionary<int, int> countOfIndexes = new();

    // map frequencies to the element
	for (int i = 0; i < nums.Length; i++)
	{
		if (!countOfIndexes.ContainsKey(nums[i]))
		{
			countOfIndexes.Add(nums[i], 0);
		}
		countOfIndexes[nums[i]]++;
	}

    //keys are array's elements and priorities are frequency of the element in array, keep the size of queue fixed based on k parameter
    var pq = new PriorityQueue<int, int>();
    foreach (var key in countOfIndexes.Keys)
    {
        pq.Enqueue(key, countOfIndexes[key]);
        if (pq.Count > k) pq.Dequeue();
    }

    //add the keys to the result array 
    int i2 = k;
    while (pq.Count > 0)
    {
        resultArr[--i2] = pq.Dequeue();
    }
    return resultArr;
}
