using _3_1;
using _3_1.Services;

Console.WriteLine("Выполнил студент группы 453502, Бибиков Максим Алексеевич, Вариант 15\n");
while (true)
{
    while (true)
    {
        int tmp = IO.ReadInteger("Введите 1 - для продолжения, 2 - для выхода: ");
        if (tmp == 2)
        {
            Environment.Exit(0);
        }
        else if (tmp == 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод! Введите ещё раз: ");
        }
    }

    Console.WriteLine("Задания из лабораторной работы №3");
    Console.WriteLine("\tЗадание 1\n\tЗадание 2\n\tЗадание 3");
    Console.WriteLine("Для выбора, введите только цифру задания: ");
    while (true)
    {
        int tmp = IO.ReadInteger(null);
        if (tmp == 1)
        {
            FirstTask.Task1();
            break;
        }
        if (tmp == 2)
        {
            SecondTask.Task2();
            break;
        }
        if (tmp == 3)
        {
            DateService.ThirdTask();
            break;
        }
        Console.WriteLine("Некорректный ввод! Введите ещё раз: ");
    }
}
