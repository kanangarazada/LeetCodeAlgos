//LeetCode 49
//Given an array of strings strs, group the anagrams together. You can return the answer in any order.
static IList<IList<string>> GroupAnagrams(string[] strs)
{
	//values of the dictionary are anagram groups
	Dictionary<string, IList<string>> result = new();

	foreach (string s in strs)
	{
		//index of the character represents place of character in the alphabet and the value of element represents the count of character in the string
		char[] hash = new char[26];
		foreach (char c in s)
		{
			hash[c - 'a']++;
        }

		// create string which is pattern for the string and add it to the dictionary based on this key 
		string key = new string(hash);
        if (!result.ContainsKey(key))
		{
			result[key] = new List<string>();
		}
		result[key].Add(s);
	}

	return result.Values.ToList();
}