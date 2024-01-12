class Many_Dimension
{
    private bool user_values = false;
    private int[][] array;
    private int size;
    public Many_Dimension()
    {
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
    public bool Values_Type
    {
        get
        {
            return user_values;
        }
        set
        {
            user_values = value;
        }
    }
    public int Size
    {
        get
        {
            return size;
        }
        set 
        {
            size = value; 
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
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            array[i] = new int[size];
            for (int j = 0; j < array[i].Length; j++)
            {
                array[i][j] = random.Next(0, 100);
            }
        }
        return array;
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