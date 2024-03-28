class Program
{
    static void Main()
    {
        OneDmassive<int> intarray = new();
        intarray.Print();
        OneDmassive<double> doublearray = new();
        doublearray.Print();
        intarray.Add(6);
        intarray.Print();
        doublearray.Add(7.2);
        doublearray.Print();
        intarray.DeleteElem(3);
        intarray.Print();
        doublearray.DeleteElem(4);
        doublearray.Print();
        intarray.Sorting();
        intarray.Print();
        doublearray.Sorting();
        doublearray.Print();
        intarray.CountwithIf((i) =>
        {
            if (i > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        });
        doublearray.CountwithIf((i) =>
        {
            if (i < -48.3)
            {
                return true;
            }
            else
            {
                return false;
            }
        });
        Console.WriteLine(doublearray.EvenifOne((i) => { if (i < 10) { return true; } else { return false; } }));

        Console.WriteLine(intarray.EvenifOne((i) => { if (i <0) { return true; } else { return false; } }));
        Console.WriteLine(intarray.IfAll((i)=> { if (i>9) { return true; } else { return false; } }));
        Console.WriteLine(doublearray.IfAll((i) => { if (i > 9) { return true; } else { return false; } }));
    }
}

