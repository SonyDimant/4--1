class Program
{
    static void Main()
    {
        Console.WriteLine("Напишите емкость массива или 0, если дефолт");
        int n = int.Parse(Console.ReadLine());
        OneDmassive<int> intarray = (n == 0) ? new() : new(n);
        Console.WriteLine("Напишите размер массива");
        int _n = int.Parse(Console.ReadLine());
        for (int i = 0; i < _n; i++)
        {
            intarray.Add(int.Parse(Console.ReadLine()));
        }
        intarray.Print();
        OneDmassive<double> doublearray = new();
        doublearray.Print();
        intArray.Add(4);
        intArray.Add(23);
        intArray.Add(424);
        intArray.Add(4345);
        intArray.Add(73445);
        intArray.Add(15);
        doubleArray.Add(834.46);
        doubleArray.Add(756.25);
        doubleArray.Add(923.6);
        doubleArray.Add(0.235);
        doubleArray.Add(0.5);
        intarray.Countel();
        intarray.ForEachAct((i) => Console.WriteLine(i) );
        intarray.Print();
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
        
        Console.WriteLine(intarray.Check(int.Parse(Console.ReadLine())));
        intarray.Max();
        intarray.Min();
        Console.WriteLine("First even element");
        Console.WriteLine(doublearray.EvenifOne((i) => { if (i < 10) { return true; } else { return false; } }));
        Console.WriteLine(intarray.EvenifOne((i) => { if (i < 0) { return true; } else { return false; } }));
        Console.WriteLine("All elements > 9");
        Console.WriteLine(intarray.IfAll((i) => { if (i > 9) { return true; } else { return false; } }));
        Console.WriteLine(doublearray.IfAll((i) => { if (i > 9) { return true; } else { return false; } }));
    }
}

