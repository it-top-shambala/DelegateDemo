namespace DelegateDemo.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            
            products.Add("apple");
            
            products.Log = Console.WriteLine;
            products.Log += LogToFile;

            products.Add("apple");
            
            products.Log -= Console.WriteLine;
            
            products.Add("apple");
        }

        static void LogToFile(string message)
        {
            using StreamWriter file = new StreamWriter("products.log", true);
            file.WriteLine(message);
        }
    }
}