
class One_Dimension
{
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
        for (int h = 0; h < size; h++)
        {
            Console.Write($"{array[h]} ");
        }
        Console.WriteLine();
    }

    public void Random_array()
    {
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(0, 100);
        }
    }


    public void Input_array()
    {
        Console.WriteLine("Enter a string with all values of an array separated by spaces");
        string input = Console.ReadLine();
        string[] input_lst = input.Split();
        for (int i = 0; i < size; i++)
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
        decimal avg = summ / size;
        return avg;
    }

    public void Delete_Over()
    {
        int[] array2 = array;
        for (int x = 0; x < size; x++)
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
        array = array2;
    }


    public void Unique()
    {
        int newarrayLength = size;
        for (int i = 0; i < size; i++)
        {
            for (int j = i; j < size; j++)
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
        for (int a = 0; a < size; a++)
        {
            if (!Contain(newarray, array[a]))
            {
                newarray[counter] = array[a];
                counter++;
            }
        }
        array = newarray;
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