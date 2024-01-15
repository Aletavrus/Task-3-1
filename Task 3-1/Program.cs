using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter type of an array");
        Console.WriteLine("Options: one imension, two dimension, many dimensions");
        string type_array = Console.ReadLine();
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string get_creation_type = Console.ReadLine();
        bool creation_type = false;
        if (get_creation_type=="no")
        {
            creation_type = false;
        }
        else
        {
            creation_type = true;
        }
        if (type_array == "one dimension")
        {
            Console.WriteLine("Enter size of an array");
            int size = int.Parse(Console.ReadLine());
            One_Dimension one_Dimension = new One_Dimension(creation_type, size);
        }
        if (type_array == "two dimension")
        {
            Console.WriteLine("Enter amount of lines of an array");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of columns of an array");
            int columns = int.Parse(Console.ReadLine());
            Two_Dimension two_Dimension = new Two_Dimension(creation_type, lines, columns);
        }
        public static int[] Create_Single(int size, bool user_values)
        {
                int[] array = new int[size];
                if (!user_values)
                {
                    Random random = new Random();
                    for (int i=0; i<size; i++)
                    {
                        array[i] = random.Next(0, 100);
                    }
                }
                else
                {
                    Console.WriteLine("Enter a string with all values of an array separated by spaces");
                    string input = Console.ReadLine();
                    string[] input_lst = input.Split();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = int.Parse(input_lst[i]);
                    }
                }
            return array;
        }
        
        public static int[][] Create_Many(int size, bool user_values)
        {
            if (!user_values)
            {
                Random random = new Random();
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = random.Next(0, 100);
                    }
                }
            }
            else
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
        }
        
        public static int[,] Create_Two(int line, int col, bool user_values)
        {
            if (!user_values)
            {
                Random random = new Random();
                for (int i = 0; i < line; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = random.Next(0, 100);
                    }
                }
            }
            else
            {
                for (int i = 0; i < line; i++)
                {
                    Console.WriteLine("Enter values of an array in 1 string with spaces between elements");
                    string input = Console.ReadLine();
                    string[] input_lst = input.Split();
                    for (int j = 0; j < column; j++)
                    {
                        array[i, j] = int.Parse(input_lst[j]);
                    }
                }
            }
            return array;
        }
    }
}
