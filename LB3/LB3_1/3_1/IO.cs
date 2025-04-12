namespace _3_1;

public class IO
{
    public static int ReadInteger(string? msg)
    {
        if (msg != null)
        {
            Console.WriteLine(msg);
        }

        int res;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out res))
            {
                return res;
            }

            Console.Write("Некорректный ввод! Введите ещё раз: ");
        }
    }
    
    public static double ReadDouble(string? msg)
    {
        if (msg != null)
        {
            Console.WriteLine(msg);
        }

        double res;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out res))
            {
                return res;
            }

            Console.Write("Некорректный ввод! Введите ещё раз: ");
        }
    }
}