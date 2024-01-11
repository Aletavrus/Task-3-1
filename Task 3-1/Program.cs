using System;
class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Enter type of an array");
        Console.WriteLine("Options: one imension, two dimension, many dimensions");
        string type_array = Console.ReadLine();
        if (type_array == "one dimension")
        {
            One_Dimension one_Dimension = new One_Dimension();
            int[] array = One_Dimension.Create_Array(one_Dimension.user_values);
            One_Dimension.Print(array);
        }
    }
}