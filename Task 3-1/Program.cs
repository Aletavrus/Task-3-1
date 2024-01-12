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
    }
}