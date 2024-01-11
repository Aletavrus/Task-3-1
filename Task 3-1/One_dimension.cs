
class One_Dimension
{
    public bool user_values;
    public One_Dimension()
    {
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string get_creation_type = Console.ReadLine();
        user_values = false;
        if (get_creation_type == "no")
        {
            user_values = true;
        }
    }

    public static void Print(int[] array)
    {
        for (int h = 0; h < array.Length; h++)
        {
            Console.Write($"{array[h]} ");
        }
        Console.WriteLine();
    }

    public static int[] Create_Array(bool user_values)
    {
        Console.WriteLine("Enter a size of an array");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        if (!user_values)
        {
            array = Random_Array(array);
        }
        else
        {
            array = Input_Array(array);
        }
        return array;
    }


    public static int[] Random_Array(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 100);
        }
        return array;
    }


    public static int[] Input_Array(int[] array)
    {
        Console.WriteLine("Enter a string with all values of an array separated by spaces");
        string input = Console.ReadLine();
        string[] input_lst = input.Split();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(input_lst[i]);
        }
        return array;
    }


    public static decimal Average(int[] array)
    {
        int summ = 0;
        foreach (int number in array)
        {
            summ += number;
        }
        decimal avg = summ / array.Length;
        return avg;
    }

    public static int[] Check(int[] arr)
    {
        int[] arr2 = arr;
        for (int x = 0; x < arr.Length; x++)
        {
            if (Math.Abs(arr[x]) > 100)
            {
                arr2 = new int[x];
                for (int y = 0; y < x; y++)
                {
                    arr2[y] = arr[y];
                }
            }
        }
        return arr2;
    }


    public static int[] Unique(int[] arr)
    {
        int newArrLength = arr.Length;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {

                if (arr[i] == arr[j] && i != j)
                {
                    newArrLength--;
                    break;
                }
            }
        }
        int counter = 0;
        int[] newArray = new int[newArrLength];
        for (int a = 0; a < arr.Length; a++)
        {
            if (!Contain(newArray, arr[a]))
            {
                newArray[counter] = arr[a];
                counter++;
            }
        }
        return newArray;
    }

    public static bool Contain(int[] k, int symb)
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