using System;
using System.Data;

class Two_Dimension
{
    public bool user_values;
    public Two_Dimension()
    {
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string get_creation_type = Console.ReadLine();
        user_values = false;
        if (get_creation_type == "no")
        {
            user_values = true;
        }
    }

    public static int[,] Create_Array(bool user_values)
    {
        Console.WriteLine("Enter amount of lines in an array");
        int line = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount of columns in an array");
        int col = int.Parse(Console.ReadLine());
        int[,] array = new int[line, col];
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


    public static int[,] Input_Array(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.WriteLine("Enter values of an array in 1 string with spaces between elements");
            string input = Console.ReadLine();
            string[] input_lst = input.Split();
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = int.Parse(input_lst[j]);
            }
        }
        return array;
    }

    public static int[,] Random_Array(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(0, 100);
            }
        }
        return array;
    }

    public static decimal Average(int[,] array)
    {
        int summ = 0;
        foreach (int number in array)
        {
            summ += number;
        }
        decimal avg = summ / array.Length;
        return avg;
    }

    public static void Print(int[,] array)
    {
        for (int i = 0; i<array.GetLength(0); i++)
        {
            for (int j = 0; j<array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Print_Even_Lines(int[,] array) //элементы четных строк в обратном порядке
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = array.GetLength(1) - 1; j > 0; j--)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public static int Split_Matrix(int[,] matrix) //здесь и дальше алгоритм поиска определителя матрицы
    {
        int total = 0;
        int counter = 0;
        int size_of_matrix = matrix.GetLength(0);
        int new_size = size_of_matrix - 1;
        if (size_of_matrix == 2)
        {
            return Find_Definitor(matrix);
        }
        else
        {
            for (int n = 0; n < size_of_matrix; n++)
            {
                int[,] new_matrix = new int[new_size, new_size];
                for (int line = 1; line < size_of_matrix; line++)
                {
                    for (int col = 0; col < size_of_matrix; col++)
                    {
                        if (col != n)
                        {
                            if (n == size_of_matrix - 1)
                            {
                                new_matrix[line - 1, col] = matrix[line, col];
                            }
                            else
                            {
                                if (col != 0)
                                {
                                    if (col < new_size & new_matrix[line - 1, col - 1] != 0)
                                    {
                                        new_matrix[line - 1, col] = matrix[line, col];
                                    }
                                    else
                                    {
                                        new_matrix[line - 1, col - 1] = matrix[line, col];
                                    }
                                }
                                else
                                {
                                    new_matrix[line - 1, col] = matrix[line, col];
                                }
                            }
                        }
                    }
                }
                int k = 0;
                if (counter % 2 == 0)
                {
                    k = 1;
                }
                else
                {
                    k = -1;
                }
                counter += 1;
                if (new_size == 2)
                {
                    int definer = Two_Mansion(matrix, new_matrix, n, k);
                    total += definer;
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        total += Split_Matrix(new_matrix) * matrix[0, n] * k;
                    }
                    else
                    {
                        total += Split_Matrix(new_matrix) * matrix[0, n] * k;
                    }
                }
            }
        }
        return total;
    }
    public static int Find_Definitor(int[,] matrix) //Находит определитель двоичной матрицы
    {
        int definitor = (matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]);
        return definitor;
    }

    public static int Two_Mansion(int[,] old_matrix, int[,] new_matrix, int n, int k) /*Перемножает элемент (old_matrix[0, n]) на его алгебраическое дополнение (definitor)
                                                                                      c учетом коэффициента порядка (k)*/
    {
        int definitor = Find_Definitor(new_matrix);
        definitor = old_matrix[0, n] * k * definitor;
        return definitor;
    }

}
