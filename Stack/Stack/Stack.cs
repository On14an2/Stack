public class Stack<T>
{
    private List<T> data;

    public Stack()
    {
        data = new List<T>();
    }

    public void Push(T item)
    {
        data.Add(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст.");
        }

        int lastIndex = data.Count - 1;
        T item = data[lastIndex];
        data.RemoveAt(lastIndex);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек пуст.");
        }

        return data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        return data.Count == 0;
    }

    public int Count()
    {
        return data.Count;
    }

    public void Clear()
    {
        data.Clear();
    }
}