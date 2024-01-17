
class One_Dimension
{
    private Random random;
    private int[] array;
    public One_Dimension(int size, bool user_values = false)
    {
        array = new int[size];
        if (!user_values)
        {
            Random_array();
        }
        else
        {
            Input_array();
        }
    }

    public void Recreate(int size, bool user_values = false)
    {
        array = new int[size];
        if (!user_values)
        {
            Random_array();
        }
        else
        {
            Input_array();
        }
    }

    public void Print()
    {
        for (int h = 0; h < array.Length; h++)
        {
            Console.Write($"{array[h]} ");
        }
        Console.WriteLine();
    }

    private static void Print(int[] ChangedArray)
    {
        for (int h = 0; h < ChangedArray.Length; h++)
        {
            Console.Write($"{ChangedArray[h]} ");
        }
        Console.WriteLine();
    }

    public void Random_array()
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
        }
    }


    public void Input_array()
    {
        Console.WriteLine("Enter a string with all values of an array separated by spaces");
        string input = Console.ReadLine();
        string[] input_lst = input.Split();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input_lst[i]);
        }
    }


    public decimal Average()
    {
        int summ = 0;
        foreach (int number in array)
        {
            summ += number;
        }
        decimal avg = summ / array.Length;
        return avg;
    }

    public void Delete_Over()
    {
        int[] array2 = new int[array.Length];
        Array.Copy(array, array2, array.Length);
        for (int x = 0; x < array.Length; x++)
        {
            if (Math.Abs(array[x]) > 100)
            {
                array2 = new int[x];
                for (int y = 0; y < x; y++)
                {
                    array2[y] = array[y];
                }
            }
        }
        Print(array2);
    }


    public void Unique()
    {
        int newarrayLength = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {

                if (array[i] == array[j] && i != j)
                {
                    newarrayLength--;
                    break;
                }
            }
        }
        int counter = 0;
        int[] newarray = new int[newarrayLength];
        for (int a = 0; a < array.Length; a++)
        {
            if (!Contain(newarray, array[a]))
            {
                newarray[counter] = array[a];
                counter++;
            }
        }
        Print(newarray);
    }

    public bool Contain(int[] k, int symb)
    {
        for (int g = 0; g < k.Length; g++)
        {
            if (symb == k[g])
            {
                return true;
            }
        }
        return false;
    }
}