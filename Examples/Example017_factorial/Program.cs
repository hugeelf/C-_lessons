int FactorialNumber(int number)
{
    if (number == 1)
    {
        return 1;
    }
    else
    {
       return number * FactorialNumber(number - 1);
    }
}

Console.WriteLine(FactorialNumber(123));