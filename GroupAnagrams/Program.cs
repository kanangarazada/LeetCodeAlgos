static IList<IList<string>> GroupAnagrams(string[] strs)
{
	Dictionary<string, IList<string>> result = new();

	foreach (string s in strs)
	{
		char[] hash = new char[26];
		foreach (char c in s)
		{
			hash[c - 'a']++;
        }

		string key = new string(hash);
        if (!result.ContainsKey(key))
		{
			result[key] = new List<string>();
		}
		result[key].Add(s);
	}

	return result.Values.ToList();
}