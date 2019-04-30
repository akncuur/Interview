public bool IsPalindrome(int number)
{
    if (number < 0 || (number % 10 == 0 && number != 0))
    {
        return false;

    int revertedNumber = 0;
    
    while(number > revertedNumber)
    {
        revertedNumber = revertedNumber*10 + number % 10;
        number /= 10;

    return number == revertedNumber || number == revertedNumber / 10;
}
