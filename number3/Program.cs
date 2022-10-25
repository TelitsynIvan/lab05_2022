namespace number3;
using MyDictionary;


class Program
{
    static void Main()
    {
        MyDictionary<int, int> test = new MyDictionary<int, int>();
        test.Add(1, 1);
        test.Add(2, 2);
        foreach (var i in test)
        {
            Console.WriteLine($"{i}");
        }
    }
}

