class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Note: ALWAYS answer with lower case letters");
        Console.WriteLine("Enter type of an array");
        Console.WriteLine("Options: one dimension, two dimension, many dimensions");
        string type_array = Console.ReadLine();
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string get_creation_type = Console.ReadLine();
        bool user_values = false;
        if (get_creation_type == "no")
        {
            user_values = true;
        }
        if (type_array == "one dimension")
        {
            Console.WriteLine("Enter size of an array");
            int size = int.Parse(Console.ReadLine());
            One_Dimension one_Dimension = new One_Dimension(user_values, size);
            Console.WriteLine($"Average: {one_Dimension.Average()}");
            one_Dimension.Delete_Over();
            one_Dimension.Print();
            one_Dimension.Unique();
            one_Dimension.Print();
        }
        if (type_array == "two dimension")
        {
            Console.WriteLine("Enter amount of lines of an array");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of columns of an array");
            int columns = int.Parse(Console.ReadLine());
            Two_Dimension two_Dimension = new Two_Dimension(user_values, lines, columns);
        }
        if (type_array == "many dimensions")
        {
            Console.WriteLine("Enter amount of arrays in a big array");
            int size = int.Parse(Console.ReadLine());
            Many_Dimension many_Dimension = new Many_Dimension(user_values, size);
        }

        static int[] Create_Single(int size, bool user_values) //если это добавить к методу Get_Array из One_Dimension, то я смогу отдельно массив задать
        {
            int[] array = new int[size];
            if (!user_values)
            {
                Random random = new Random();
                for (int i = 0; i < size; i++)
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

        static int[][] Create_Many(int size, bool user_values)
        {
            int[][] array = new int[size][];
            if (!user_values)
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
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("Enter size of an inner array");
                    int size_inner = int.Parse(Console.ReadLine());
                    array[i] = new int[size_inner];
                    Console.WriteLine("Enter values of 1 inner array in 1 string with spaces between elements");
                    string input = Console.ReadLine();
                    string[] input_lst = input.Split();
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] = int.Parse(input_lst[j]);
                    }
                }
            }
            return array;
        }

        static int[,] Create_Two(int line, int column, bool user_values)
        {
            int[,] array = new int[line, column];
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
