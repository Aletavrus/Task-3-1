class Many_Dimension
{
    private bool user_values = false;
    private int[][] array;
    public Many_Dimension(bool creation_type, int size)
    {
        user_values = creation_type;
        array = new int[size][];
        if (!user_values)
        {
            array = Random_Array();
        }
        else
        {
            array = Input_Array();
        }
    }


    public int[][] Input_Array()
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
        return array;
    }

    public int[][] Random_Array()
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            int size_inner = random.Next(1, 5);
            array[i] = new int[size_inner];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(0, 100);
            }
        }
        return array;
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

    public decimal Average_of_All()
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
        return avg;
    }

    public int[][] Even_Num_Change()
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int y = 0; y < array[i].Length; y++)
            {
                if (array[i][y] % 2 == 0)
                {
                    array[i][y] = i * y;
                }
            }
        }
        return array;
    }

}
