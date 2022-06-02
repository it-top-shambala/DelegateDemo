namespace DelegateDemo.Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            int res = 0;
            res = Calculator.Calc(x, y, (a, b) => a + b);
            res = Calculator.Calc(x, y, (i, i1) => i * i1);
            res = Calculator.Calc(x, y, (ix, iy) => ix - iy);
            res = Calculator.Calc(x, y, (ix, iy) => ix > iy ? ix : iy);
            res = Calculator.Calc(x, y, (ix, iy) => (ix + iy) / 2);
        }

        static int Sub(int x, int y) => x - y;
    }
}