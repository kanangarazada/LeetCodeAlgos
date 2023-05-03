static int[] TopKFrequent(int[] nums, int k)
{
    int[] resultArr = new int[k];
    Dictionary<int, int> countOfIndexes = new();

	for (int i = 0; i < nums.Length; i++)
	{
		if (!countOfIndexes.ContainsKey(nums[i]))
		{
			countOfIndexes.Add(nums[i], 0);
		}
		countOfIndexes[nums[i]]++;
	}

    var pq = new PriorityQueue<int, int>();
    foreach (var key in countOfIndexes.Keys)
    {
        pq.Enqueue(key, countOfIndexes[key]);
        if (pq.Count > k) pq.Dequeue();
    }
    int i2 = k;
    while (pq.Count > 0)
    {
        resultArr[--i2] = pq.Dequeue();
    }
    return resultArr;
}

foreach(var item in TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2))
{
    Console.WriteLine(item);
}