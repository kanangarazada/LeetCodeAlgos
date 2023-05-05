//Lintcode 659
//Design an algorithm to encode a list of strings to a string. The encoded string is then sent over the network and is decoded back to the original list of strings.
static string Encode(IList<string> strs) 
{
	string result = "";

    foreach (string str in strs)
    {
        result += str.Length + "#" + str;
    }

    return result;
}


static IList<string> Decode(string s)
{
    var result = new List<string>();

    int i = 0;
    while(i < s.Length)
    {
        int j = i;
        while (s[j] != '#')
        {
            j++;
        }

        //get the length of encoded string
        int.TryParse(s.Substring(i, j - i), out var len);
        j++;
        result.Add(s.Substring(j, len));
        i = j + len;
    }

    return result;
}
