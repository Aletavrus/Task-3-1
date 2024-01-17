using System;
using System.Data;

class Two_Dimension
{
    private int[,] array;
    public Two_Dimension(int line, int column, bool user_values = false)
    {
        int[,] array = new int[line, column];
        if (!user_values)
        {
            Random_Array();
        }
        else
        {
            Input_Array();
        }
    }

    public void Recreate(int line, int column, bool user_values = false)
    {
        int[,] array = new int[line, column];
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

    public void Random_Array()
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

    public void Print()
    {
        for (int i = 0; i<line; i++)
        {
            for (int j = 0; j<column; j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void Print_Even_Lines() //элементы четных строк в обратном порядке
    {
        for (int i = 0; i < line; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = column - 1; j > 0; j--)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public int Split_array(int[,] array) //здесь и дальше алгоритм поиска определителя матрицы
    {
        int total = 0;
        int counter = 0;
        int size_of_array = line;
        int new_size = size_of_array - 1;
        if (size_of_array == 2)
        {
            return Find_Definitor(array);
        }
        else
        {
            for (int n = 0; n < size_of_array; n++)
            {
                int[,] new_array = new int[new_size, new_size];
                for (int line = 1; line < size_of_array; line++)
                {
                    for (int col = 0; col < size_of_array; col++)
                    {
                        if (col != n)
                        {
                            if (n == size_of_array - 1)
                            {
                                new_array[line - 1, col] = array[line, col];
                            }
                            else
                            {
                                if (col != 0)
                                {
                                    if (col < new_size & new_array[line - 1, col - 1] != 0)
                                    {
                                        new_array[line - 1, col] = array[line, col];
                                    }
                                    else
                                    {
                                        new_array[line - 1, col - 1] = array[line, col];
                                    }
                                }
                                else
                                {
                                    new_array[line - 1, col] = array[line, col];
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
                    int definer = Two_Mansion(array, new_array, n, k);
                    total += definer;
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        total += Split_array(new_array) * array[0, n] * k;
                    }
                    else
                    {
                        total += Split_array(new_array) * array[0, n] * k;
                    }
                }
            }
        }
        return total;
    }
    public static int Find_Definitor(int[,] array) //Находит определитель двоичной матрицы
    {
        int definitor = (array[0, 0] * array[1, 1]) - (array[1, 0] * array[0, 1]);
        return definitor;
    }
    public static int Two_Mansion(int[,] old_array, int[,] new_array, int n, int k) /*Перемножает элемент (old_array[0, n]) на его алгебраическое дополнение (definitor)
                                                                                      c учетом коэффициента порядка (k)*/
    {
        int definitor = Find_Definitor(new_array);
        definitor = old_array[0, n] * k * definitor;
        return definitor;
    }

}
