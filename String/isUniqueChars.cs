static bool isUniqueChars(string str)
{
    bool[] charOfValue = new bool[128];
    for(int i = 0; i< str.Length;i++)
    {
        int val = str[i];
        if (charOfValue[val])
            return false;
        charOfValue[val] = true;


    }

    return true;
}