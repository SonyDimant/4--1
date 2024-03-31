public sealed class OneDmassive<T>
{
    private T[] massive;
    private Random rnd = new Random();
    private int _size;
    private int _capacity;

    public OneDmassive(int capacity)
    {
        _capacity = capacity;
        massive = new T[capacity];
        _size = 0;

    }
    public OneDmassive():this(7) { }

    public void Add(T element)
    {
        if (_size >= _capacity)
        {
            _capacity = 2 * _capacity + 1;
            T[] mas = new T[_capacity];
            Array.Copy(massive, mas, _size);
            massive = mas;
        }
        massive[_size] = element;
        _size++;
    }
    public void Print() 
    {
        Console.WriteLine("Massive");
        for (int i = 0; i < _size; i++)
        {
            Console.Write(massive[i] + " ");
        }
        Console.WriteLine();
    }

    public void DeleteElem(int index)
    {
        if (index <= _size)
        {
            T[] mas = new T[_capacity];
            for (int j = 0; j < _size; j++)
            {
                if (j !=index)
                {
                    mas[j] = massive[j];
                }
            }
            _size--;
            massive = mas;
        }
        else
        {
            Console.WriteLine("Index is out of this range");

        }
    }

    public void Sorting() 
    { 
        Array.Sort(massive, 0, _size);
    }

    public bool EvenifOne(Func<T, bool> action)
    {
        for (int i=0; i < _size; i++)
        {
            if (action(massive[i]))
            {
                return true;

            }
        }
        return false;
    }
    public void ForEachAct(Action<T> action)
    {
        for (int i = 0; i < _size; i++)
        {
            action(massive[i]);
        }
    }

    public bool IfAll(Func<T, bool> action) 
    {
        for (int i =0; i < _size; i++)
        {
            if (!action(massive[i])) 
            {
                return false;
            }
        }
        return true;
    }
    public void Countel()
    {
        int s = 0;
        for (int i=0 ; i < _size ; i++)
        {
            s++;
        }
        Console.WriteLine(s);
    }
    public void CountwithIf(Func<T, bool> action) 
    {
        int b = 0;
        for (int i=0 ; i < _size ; i++)
        {
            if (action(massive[i]))
            {
                b++;
            }
        }
        Console.WriteLine(b);
    }

    public bool Check(int element) 
    {
        for (int i=0;i< _size; i++)
        {
            if (i != element)
            {
                return false;
            }
        }
        return true;
    }
    public void Max()
    {
        int maxx = 0;
        for (int i=0; i< _size; i++)
        {
            if (i>maxx)
            {
                maxx = i;
            }
        }
        Console.WriteLine(maxx);
    }
    public void Min() 
    {  
        int minx = 1000000;
        for ( int i=0; i< _size;i++)
        {
            if (i>minx) 
            {
                minx = i;
            }
        }
        Console.WriteLine(minx);
    }
}
