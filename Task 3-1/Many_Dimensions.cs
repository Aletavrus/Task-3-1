﻿class ManyDimension
{
    private Random _random = new Random();
    private int[][] _array;
    public ManyDimension(int size, bool user_values = false)
    {
        _array = new int[size][];
        if (!user_values)
        {
            Random_Array();
        }
        else
        {
            Input_Array();
        }
    }

    public void Recreate(int size, bool user_values = false)
    {
        _array = new int[size][];
        if (!user_values)
        {
            Random_Array();
        }
        else
        {
            Input_Array();
        }
    }

    public void Input_Array()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            _array[i] = new int[size];
            Console.WriteLine("Enter values of 1 inner array in 1 string with spaces between elements");
            string input = Console.ReadLine();
            string[] input_lst = input.Split();
            for (int j = 0; j < _array[i].Length; j++)
            {
                _array[i][j] = int.Parse(input_lst[j]);
            }
        }
    }

    public void Random_Array()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            _array[i] = new int[size];
            for (int j = 0; j < _array[i].Length; j++)
            {
                _array[i][j] = _random.Next(1, 100);
            }
        }
    }

    public void Print()
    {
        _print(_array);
    }

    private static void _print(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j=0; j < array[i].Length; j++)
            {
                Console.Write($"{array[i][j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Average_of_Single()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            int summ = 0;
            for (int j = 0; j < _array[i].Length; j++)
            {
                summ += _array[i][j];
            }
            decimal avg = summ / _array[i].Length;
            Console.WriteLine($"Average of values in {i} inner array = {avg}");
        }
    }

    public void Average_of_All()
    {
        int summ = 0;
        int totalLength = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                summ += _array[i][j];
                totalLength++;
            }
        }
        decimal avg = summ / totalLength;
        Console.WriteLine($"Average of all elements in array = {avg}");
    }

    public void Even_Num_Change()
    {
        int[][] newArray = new int[_array.Length][];
        Array.Copy(_array, newArray, _array.Length);
        for (int i = 0; i < _array.Length; i++)
        {
            for (int y = 0; y < _array[i].Length; y++)
            {
                if (_array[i][y] % 2 == 0)
                {
                    newArray[i][y] = i * y;
                }
            }
        }
        _print(newArray);
    }

}
