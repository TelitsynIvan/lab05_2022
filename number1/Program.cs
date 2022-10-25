using System.Formats.Asn1;

namespace Program;
using MyMatrix;


class Program
{
    static void Main()
    {
        MyMatrix.from = 0;
        MyMatrix.to = 10;
        MyMatrix one = new MyMatrix(3, 3);
        foreach (var str in one.data)
        {
            foreach (var col in str)
            {
                Console.Write($"{col}; ");
            }
            Console.Write('\n');
        }
        one.ChangeSize(4, 4);
        foreach (var str in one.data)
        {
            foreach (var col in str)
            {
                Console.Write($"{col}; ");
            }
            Console.Write('\n');
        }
        one.ShowPartialy(2, 3, 2, 3);
        one[0, 0] = 9;
        Console.WriteLine(one[0,0]);
    }
}