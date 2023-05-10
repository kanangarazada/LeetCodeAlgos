//LeetCode 739
//Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i]
//is the number of days you have to wait after the ith day to get a warmer temperature
static int[] DailyTemperatures(int[] temperatures)
{
	int[] result = new int[temperatures.Length];

	//index of the temperatures
	var stack = new Stack<int>();

	for (int i = 0; i < temperatures.Length; i++)
	{
		var t = temperatures[i];

		//monotonic decreasing stack 
		while (stack.Any() && temperatures[stack.Peek()] < t)
		{
            var prev = stack.Pop();
            result[prev] = i - prev;
        }

		stack.Push(i);
	}

    return result;
}

foreach (var item in DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 }))
{
    Console.WriteLine(	item);
}  