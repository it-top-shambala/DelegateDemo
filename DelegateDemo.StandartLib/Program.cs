namespace DelegateDemo.StandartLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Calculator.Calc(5, 4, (x, y) => x + y);
            Console.WriteLine(res);
            var max = Calculator.Calc(5, 10, (x, y) => x > y ? x : y);
            Console.WriteLine(max);

            var array = new int[] { 1, 2, 3, 4, 5, -1, -2, -3, -4, -5, 0, 0, 0 };
            
            int sumPositive = 0;
            int sumNegative = 0;

            int countPositive = 0;
            int countNegative = 0;
            foreach (var i in array)
            {
                Calculator.CalcIf(i, 
                    x => x > 0, 
                    x => ++countPositive, 
                    x => ++countNegative);
                
                Calculator.CalcIf(i, 
                    x => x > 0, 
                    x => sumPositive += x, 
                    x => sumNegative += x);
            }
            
            Console.WriteLine(countNegative);
            Console.WriteLine(countPositive);
            
            Console.WriteLine(sumNegative);
            Console.WriteLine(sumPositive);
        }
    }
}