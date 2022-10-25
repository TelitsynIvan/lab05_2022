namespace MyList;



public class MyList<T>
{
    private T[] data;
    private int size;


    public MyList()
    {
        data = new T[0];
        size = 0;
    }
    public MyList(T[] data)
    {
        this.data = data;
        size = data.Length;
    }

    public void Add(T item)
    {
        int sizet = size;
        size++;
        T[] datat = new T[size];
        for (int i = 0; i < sizet; i++)
        {
            datat[i] = data[i];
        }
        datat[sizet] = item;
        data = datat;
    }

    public T this[int index]
    {
        get
        {
            return data[index];
        }
        set
        {
            data[index] = value;
        }
    }

    public int capacity
    {
        get
        {
            int cap=0;
            for (int i = 0; i < size; i++)
            {
                if (data[i] != null)
                {
                    cap++;
                }
            }
            return cap;
        }
    }
}