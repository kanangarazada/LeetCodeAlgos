//LeetCode 125
//A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters,
using System.Numerics;

static bool IsPalindrome(string s)
{
    for (int left = 0, right = s.Length - 1; left < right; left++, right--) 
    {
        while (!IsAlphaNumerical(s[left]) && left < right) ++left;
        while (!IsAlphaNumerical(s[right]) && right > left) --right;

        if (s[left].ToString().ToLower() != s[right].ToString().ToLower())
        {
            return false;
        }
    }

    return true;
}


static bool IsAlphaNumerical (char c)
{
    return (c >= 'A' && c <= 'Z')
        || (c >= 'a' && c <= 'z')
        || (c >= '0' && c <= '9');
}

Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));