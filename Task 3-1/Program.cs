using System.ComponentModel.DataAnnotations.Schema;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Note: ALWAYS answer with lower case letters");
        Console.WriteLine("Enter type of an array");
        Console.WriteLine("Options: one dimension, two dimension, many dimensions");
        string typeArray = Console.ReadLine();
        Console.WriteLine("Do you want to have randomly generated values in array?");
        string getCreationType = Console.ReadLine();
        bool userValues = false;
        if (getCreationType == "no")
        {
            userValues = true;
        }
        if (typeArray == "one dimension")
        {
            Console.WriteLine("Enter size of an array");
            int size = int.Parse(Console.ReadLine());
            OneDimension oneDimension = new OneDimension(size, userValues);
            oneDimension.Average();
            oneDimension.DeleteOver();
            oneDimension.Unique();
        }
        if (typeArray == "two dimension")
        {
            Console.WriteLine("Enter amount of lines of an array");
            int lines = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter amount of columns of an array");
            int columns = int.Parse(Console.ReadLine());
            TwoDimension twoDimension = new TwoDimension(lines, columns, userValues);
            twoDimension.Average();
            twoDimension.Print();
            twoDimension.PrintEvenLines();
            //Console.WriteLine($"Matrix Determiner = {twoDimension.Split_array(twoDimension.GetArray)}");
        }
        if (typeArray == "many dimensions")
        {
            Console.WriteLine("Enter amount of arrays in a big array");
            int size = int.Parse(Console.ReadLine());
            ManyDimension manyDimension = new ManyDimension(size, userValues);
            //manyDimension.EvenNumChange();
            //manyDimension.Print();
            //manyDimension.Average_of_Single();
            //manyDimension.Average_of_All();
        }
    }
}
