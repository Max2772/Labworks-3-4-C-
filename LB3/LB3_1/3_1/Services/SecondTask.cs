namespace _3_1.Services;

public class SecondTask {
    static public void SolveProblem(double z)
    {
        double x;
        if (z > 0)
        {
            x = -3 * z;
        }else
        {
            x = z * z;
        }
        
        double res = x * (Math.Sin(x) + Math.Pow(double.Epsilon, (-1) * (x + 3)));
        Console.WriteLine("Результат: " + res);
    }
    
    public static void Task2()
    {
        Console.WriteLine("Разработать метод f(z), который высчитывает y = x(sinx + e^(-(x+3)).\n" + 
                          "Где x = -3z при z > 0 и x = z^2 при z <= 0.");
        double z = IO.ReadDouble("Введите z: ");
        SolveProblem(z);
    }
}