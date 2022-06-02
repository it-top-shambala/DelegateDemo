namespace DelegateDemo.StandartLib;

public static class Calculator
{
    public static int Calc(int x, int y, Func<int, int, int> func) => func(x, y);

    public static int CalcIf(int x, Predicate<int> predicate, Func<int, int> funcTrue, Func<int, int> funcFalse) => predicate(x) ? funcTrue(x) : funcFalse(x);
}