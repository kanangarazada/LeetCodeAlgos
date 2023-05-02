static bool isAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, int> sMap = new();
    Dictionary<char, int> tMap = new();

    for (int i = 0; i < s.Length; i++)
    {
        sMap[s[i]] = 1 + (sMap.TryGetValue(s[i], out int sCount) ? sCount : 0);
        tMap[t[i]] = 1 + (tMap.TryGetValue(t[i], out int tCount) ? tCount : 0);
    }

    foreach (char c in sMap.Keys)
    {
        if (!tMap.ContainsKey(c) || (tMap.ContainsKey(c) && sMap[c] != tMap[c])) 
        {
            return false;
        }
    }

    return true;
}