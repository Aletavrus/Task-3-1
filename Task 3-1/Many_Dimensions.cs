using System;
class Many_Dimension
{
    public bool user_values;
    public Many_Dimension()
    {
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string get_creation_type = Console.ReadLine();
        user_values = false;
        if (get_creation_type == "no")
        {
            user_values = true;
        }
    }

    public static int[][] Create_Array(bool user_values)
    {
        Console.WriteLine("Enter amount of arrays in a big array");
        int size = int.Parse(Console.ReadLine());
        int[][] array = new int[size][];
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


    public static int[][] Input_Array(int[][] array)
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

    public static int[][] Random_Array(int[][] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Enter size of an inner array");
            int size = int.Parse(Console.ReadLine());
            array[i] = new int[size];
            for (int j = 0; j < array[i].Length ; j++)
            {
                array[i][j] = random.Next(0, 100);
            }
        }
        return array;
    }

    public static void Average_of_Single(int[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int summ = 0;
            for (int j=0; j < array[i].Length ;j++)
            {
                summ += array[i][j];
            }
            decimal avg = summ / array[i].Length;
            Console.WriteLine($"Average of values in {i} inner array = {avg}");
        }
    }

    public static decimal Average_of_All(int[][] array)
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

    public static int[][] Even_Num_Change(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int y = 0; y < arr[i].Length; y++)
            {
                if (arr[i][y] % 2 == 0)
                {
                    arr[i][y] = i * y;
                }
            }
        }
        return arr;
    }

}