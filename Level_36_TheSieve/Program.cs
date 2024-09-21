// -------------------- The Sieve --------------------




class Sieve
{
    private Func<int, bool> _decisionFunction;

    public bool IsGood(int number)
    {
        return _decisionFunction(number);
    }

    public Sieve(Func<int, bool> func)
    {
        _decisionFunction = func;
    }

    bool IsEven(int number) => number % 2 == 0;
    bool IsPositive(int number) => number > 0;
    bool IsMultipleOfTen(int number) => number % 10 == 0;
}