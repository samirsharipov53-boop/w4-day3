
public class Chache<T>()
{
    public T? Data;
    public void Add(T d)
    {
        Data=d;
    }
    public void Remove()
    {
        
    }
    public T Get()
    {
        return Data;
    }
}