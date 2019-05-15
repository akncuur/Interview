static bool OneAway(string s1,string s2)
{
    int diff = Math.Abs(s1.Length - s2.Length);
    int diffCount = 0;

    if (diff > 1)   return false;

    for(int i = 0; i<s1.Length- diff; i++)
    {
        if (s1[i] != s2[i]) diffCount++;
    }
    if (diffCount < 2) return true;
    else return false;
}