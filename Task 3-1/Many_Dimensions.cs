sealed class ManyDimension:ArrayBase
{
    private Random _random = new Random();
    private int[][] _array;
    public ManyDimension(int size, bool userValues = false)
    {
        Recreate(size, userValues);
    }

    public void Recreate(int size, bool userValues = false)
    {
        if (userValues)
        {
            CreateArray(size, true);
        }
        else
        {
            CreateArray(size);
        }
    }

    private override void CreateArray(int size, bool userValues = false)
    {
        _array = new int[size][];
        if (!userValues)
        {
            RandomArray();
        }
        else
        {
            InputArray();
        }
    }

    private override void InputArray()
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

    private override void RandomArray()
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

    public override void Print()
    {
        Print(_array);
    }+

    private static void Print(int[][] array)
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

    public override void Average()
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

    public void AverageOfAll()
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

    public void EvenNumChange()
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
        Print(newArray);
    }

}
