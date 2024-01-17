class Many_Dimension
{
    private Random random = new Random();
    private int[][] array;
    public Many_Dimension(int size, bool user_values = false)
    {
        array = new int[size][];
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
        array = new int[size][];
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
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            array[i] = new int[size];
            Console.WriteLine("Enter values of 1 inner array in 1 string with spaces between elements");
            string input = Console.ReadLine();
            string[] input_lst = input.Split();
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = int.Parse(input_lst[j]);
            }
        }
    }

    public void Random_Array()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            array[i] = new int[size];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(1, 100);
            }
        }
    }

    public void Print()
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

    private static void Print(int[][] ChangedArray)
    {
        for (int i = 0; i < ChangedArray.Length; i++)
        {
            for (int j=0; j < ChangedArray[i].Length; j++)
            {
                Console.Write($"{ChangedArray[i][j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Average_of_Single()
    {
        for (int i = 0; i < array.Length; i++)
        {
            int summ = 0;
            for (int j = 0; j < array[i].Length; j++)
            {
                summ += array[i][j];
            }
            decimal avg = summ / array[i].Length;
            Console.WriteLine($"Average of values in {i} inner array = {avg}");
        }
    }

    public void Average_of_All()
    {
        int summ = 0;
        int total_length = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                summ += array[i][j];
                total_length++;
            }
        }
        decimal avg = summ / total_length;
        Console.WriteLine($"Average of all elements in array = {avg}");
    }

    public void Even_Num_Change()
    {
        int[][] newarray = new int[array.Length][];
        Array.Copy(array, newarray, array.Length);
        for (int i = 0; i < array.Length; i++)
        {
            for (int y = 0; y < array[i].Length; y++)
            {
                if (array[i][y] % 2 == 0)
                {
                    newarray[i][y] = i * y;
                }
            }
        }
        Print(newarray);
    }

}
