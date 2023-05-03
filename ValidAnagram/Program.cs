//LeetCode 242
//Given two strings s and t, return true if t is an anagram of s, and false otherwise.
static bool isAnagram(string s, string t)
{
    if (s.Length != t.Length) return false;

    Dictionary<char, int> sMap = new();
    Dictionary<char, int> tMap = new();

    for (int i = 0; i < s.Length; i++)
    {   
        //map the counts of each character to the character if it is already in dictionary increment count
        sMap[s[i]] = 1 + (sMap.TryGetValue(s[i], out int sCount) ? sCount : 0);
        tMap[t[i]] = 1 + (tMap.TryGetValue(t[i], out int tCount) ? tCount : 0);
    }

    foreach (char c in sMap.Keys)
    {
        //check both dictionaries have the same character with the same value
        if (!tMap.ContainsKey(c) || (tMap.ContainsKey(c) && sMap[c] != tMap[c])) 
        {
            return false;
        }
    }

    return true;
}