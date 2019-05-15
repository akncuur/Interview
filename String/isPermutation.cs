static bool isPermutation(string str1, string str2)
{
    if (str1.Length != str2.Length)
        return false;
    return sort(str1) == sort(str2);
}

static string sort(string s)
{
    char[] content = s.ToCharArray();
    Array.Sort(content);
    return content.ToString();
}