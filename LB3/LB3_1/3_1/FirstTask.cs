namespace _3_1;

public class FirstTask{
    public static int SolveProblem(int a)
    {
        return a * a;
    }
    
    public static void Task1()
    {
        Console.WriteLine("Разработать метод f(n), который для заданного натурального числа n находит значение n^2.\n" + 
                          "Вычислить с помощью него значение выражения 2^2+3^2+4^2.");
        int a = IO.ReadInteger("Введите a: ");
        int b = IO.ReadInteger("Введите b: ");
        int c = IO.ReadInteger("Введите c: ");

        int res = SolveProblem(a) + SolveProblem(b) + SolveProblem(c);
        Console.WriteLine("Результат: " + res);    
    }
}