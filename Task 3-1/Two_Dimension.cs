using System;
using System.Data;

class TwoDimension
{
    private Random random = new Random();
    private int[,] _array;
    public TwoDimension(int line, int column, bool user_values = false)
    {
        _array = new int[line, column];
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
        _array = new int[line, column];
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
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            Console.WriteLine("Enter values of 1 line in 1 string with spaces between elements");
            string input = Console.ReadLine();
            string[] input_lst = input.Split();
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                _array[i, j] = int.Parse(input_lst[j]);
            }
        }
    }

    public void Random_Array()
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            for (int j = 0; j < _array.GetLength(1); j++)
            {
                _array[i, j] = random.Next(0, 100);
            }
        }
    }

    public void Average()
    {
        int summ = 0;
        foreach (int number in _array)
        {
            summ += number;
        }
        decimal avg = summ / _array.Length;
        Console.WriteLine($"Average = {avg}");
    }

    public void Print()
    {
        for (int i = 0; i<_array.GetLength(0); i++)
        {
            for (int j = 0; j<_array.GetLength(1); j++)
            {
                Console.Write($"{_array[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public void PrintEvenLines() //элементы четных строк в обратном порядке
    {
        for (int i = 0; i < _array.GetLength(0); i++)
        {
            if (i % 2 == 0)
            {
                for (int j = _array.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write($"{_array[i, j]} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 0; j < _array.GetLength(1); j++)
                {
                    Console.Write($"{_array[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }

    public int[,] GetArray
    {
        get
        {
            return _array;
        }
    }

    public int Split_array(int[,] array) //здесь и дальше алгоритм поиска определителя матрицы
    {
        int total = 0;
        int counter = 0;
        int sizeOfArray = array.GetLength(0);
        int newSize = sizeOfArray - 1;
        if (sizeOfArray == 2)
        {
            return FindDefinitor(array);
        }
        else
        {
            for (int n = 0; n < sizeOfArray; n++)
            {
                int[,] newArray = new int[newSize, newSize];
                for (int line = 1; line < sizeOfArray; line++)
                {
                    for (int col = 0; col < sizeOfArray; col++)
                    {
                        if (col != n)
                        {
                            if (n == sizeOfArray - 1)
                            {
                                newArray[line - 1, col] = array[line, col];
                            }
                            else
                            {
                                if (col != 0)
                                {
                                    if (col < newSize & newArray[line - 1, col - 1] != 0)
                                    {
                                        newArray[line - 1, col] = array[line, col];
                                    }
                                    else
                                    {
                                        newArray[line - 1, col - 1] = array[line, col];
                                    }
                                }
                                else
                                {
                                    newArray[line - 1, col] = array[line, col];
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
                if (newSize == 2)
                {
                    int definer = TwoMansion(array, newArray, n, k);
                    total += definer;
                }
                else
                {
                    if (n % 2 == 0)
                    {
                        total += Split_array(newArray) * array[0, n] * k;
                    }
                    else
                    {
                        total += Split_array(newArray) * array[0, n] * k;
                    }
                }
            }
        }
        return total;
    }
    private static int FindDefinitor(int[,] array) //Находит определитель двоичной матрицы
    {
        int definitor = (array[0, 0] * array[1, 1]) - (array[1, 0] * array[0, 1]);
        return definitor;
    }
    private static int TwoMansion(int[,] oldArray, int[,] newArray, int n, int k) /*Перемножает элемент (oldArray[0, n]) на его алгебраическое дополнение (definitor)                                                                                c учетом коэффициента порядка (k)*/
    {
        int definitor = FindDefinitor(newArray);
        definitor = oldArray[0, n] * k * definitor;
        return definitor;
    }

}
