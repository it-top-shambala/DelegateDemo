namespace DelegateDemo.Calc;

public delegate int Operation(int x, int y);

public static class Calculator
{
    public static int Calc(int x, int y, Operation operation)
    {
        return operation(x, y);
    }
}