namespace DelegateDemo.App;

public delegate void Message(string message);

public class Products
{
    private List<string> _products;
    
    public Message Log;

    public Products()
    {
        _products = new List<string>();
    }

    public void Add(string name)
    {
        _products.Add(name);

        /*if (Log is not null)
        {
            Log.Invoke($"{DateTime.Now:g} Добавлен товар: {name}");
        }*/
        
        Log?.Invoke($"{DateTime.Now:g} Добавлен товар: {name}");
    }

    public void Del(string name)
    {
        _products.Remove(name);
        
        Log?.Invoke($"{DateTime.Now:g} Удалён товар: {name}");
    }
}