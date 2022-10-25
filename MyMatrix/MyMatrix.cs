using System.Data;
using System.Numerics;

namespace MyMatrix;
using System.Collections.Generic;


public class MyMatrix
{
    public List<List<int>> data;
    static public int from { get; set; }
    static public int to { get; set; }

    public MyMatrix(int m, int n)
    {
        Random rd = new Random();
        data = new List<List<int>>(m);
        for (int i = 0; i < data.Capacity; i++)
        {
            List<int> temp = new List<int>(n);
            for (int j = 0; j < temp.Capacity; j++)
            {
                temp.Add(rd.Next(from, to));
            }
            data.Add(temp);
        }
    }

    public void Fill()
    {
        Random rd = new Random();
        for (int i = 0; i < data.Count; i++)
        {
            for (int j = 0; j < data[i].Capacity; j++)
            {
                data[i].Add(rd.Next(from, to));
            }
        }
    }
    public void ChangeSize(int newm, int newn)
    {
        Random rd = new Random();
        int m = data.Capacity;
        int n = data[0].Capacity;
        for (int i = 0; i < newm; i++)
        {
            if (i >= m)
            {
                data.Add(new List<int>());
            }
            for (int j = 0; j < newn; j++)
            {
                if (i >= m || j >= n)
                {
                    data[i].Add(rd.Next(from, to));
                }
            }
        }
    }

    public void ShowPartialy(int m1, int m2, int n1, int n2)
    {
        for (int i = m1-1; i < m2; i++)
        {
            for (int j = n1-1; j < n2; j++)
            {
                Console.Write($"{data[i][j]}; ");
            }
            Console.Write('\n');
        }
    }

    public void Show()
    {
        foreach (var str in data)
        {
            foreach (var col in str)
            {
                Console.Write($"{col}; ");
            }
            Console.Write('\n');
        }
    }
    public int this[int index1, int index2]{
        get
        {
            return data[index1][index2];
        }
        set
        {
            data[index1][index2] = value;
        }
    }
}