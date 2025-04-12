namespace LB4;

public class IO
{
    public static int ReadInteger(string? msg)
    {
        if (msg != null)
        {
            Console.WriteLine(msg);
        }

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out var res))
            {
                return res;
            }

            Console.Write("Incorrect input! Write again: ");
        }
    }
    
    public static double ReadDouble(string? msg)
    {
        if (msg != null)
        {
            Console.WriteLine(msg);
        }

        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out var res))
            {
                return res;
            }

            Console.Write("Incorrect input! Write again: ");
        }
    }
    
    public static string ReadString(string? msg)
    {
        if (msg != null)
        {
            Console.WriteLine(msg);
        }

        while (true)
        {
            string? str = Console.ReadLine();
            if (str != null)
            {
                return str;
            }
            Console.Write("Empty input! Write again: ");
        }
    }
}