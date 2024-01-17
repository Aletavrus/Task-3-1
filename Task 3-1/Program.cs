using System.ComponentModel.DataAnnotations.Schema;

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
            One_Dimension one_Dimension = new One_Dimension(size, user_values);
            one_Dimension.Average();
            one_Dimension.Delete_Over();
            one_Dimension.Unique();
        }
        if (type_array == "two dimension")
        {
            Console.WriteLine("Enter amount of lines of an array");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of columns of an array");
            int columns = int.Parse(Console.ReadLine());
            Two_Dimension two_Dimension = new Two_Dimension(lines, columns, user_values);
            two_Dimension.Average();
            two_Dimension.Print();
            two_Dimension.Print_Even_Lines();
            //Console.WriteLine($"Matrix Determiner = {two_Dimension.Split_array(two_Dimension.GetArray)}");
        }
        if (type_array == "many dimensions")
        {
            Console.WriteLine("Enter amount of arrays in a big array");
            int size = int.Parse(Console.ReadLine());
            Many_Dimension many_Dimension = new Many_Dimension(size, user_values);
            many_Dimension.Even_Num_Change();
            //many_Dimension.Print();
            //many_Dimension.Average_of_Single();
            //many_Dimension.Average_of_All();
        }
    }
}
