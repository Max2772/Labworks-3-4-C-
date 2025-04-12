using System.Diagnostics;
using System.Globalization;
namespace _3_1;

public class DateService
{
    public int Day, Month, Year;
    private static DateTime dateValue;
    
    public DateService(int year = 1, int month = 1, int day = 1)
    {
        Day = day;
        Month = month;
        Year = year;
        dateValue = new DateTime(Year, Month, Day);
    }
     

    public static bool ChangeDate(string? dateStr)
    {
        if (dateStr == null) return false;
        string[] dateParts = dateStr.Split('.');
        if (dateParts.Length != 3) return false;
        if (!int.TryParse(dateParts[0], out int posibleYear)) return false;
        if (!int.TryParse(dateParts[1], out int posibleMonth)) return false;
        if (!int.TryParse(dateParts[2], out int posibleDay)) return false;

        dateValue = new DateTime(posibleYear, posibleMonth, posibleDay);
        return true;
    }

    public string GetDate()
    {
        return $"{Day}.{Month}.{Year}";
    }

    public static string GetDateName()
    {
        string rusDay = dateValue.ToString("dddd", new CultureInfo("ru-RU"));
        return rusDay;
    }

    public static int DaysFromNow()
    {
        return Math.Abs((dateValue - DateTime.Now).Days);
    }
    
    

    public static void ThirdTask()
    {
        Console.WriteLine("Выберите подзадание:\n" +
                          "1. Определить день недели по дате\n" +
                          "2. Определять сколько дней пройдет между текущей датой и произвольной\n" +
                          "Для выбора введите цифру(1/2): ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result) && (result == 1 || result == 2))
            {
                Console.WriteLine("Введите произвольную дату в ввиде YYYY.MM.DD: ");

                while (true)
                {
                    string input = Console.ReadLine();
                    if (!ChangeDate(input))
                    {
                        Console.WriteLine("Некорректный ввод!\nВведите заново: ");
                    }

                    break;
                }
                
                if (result == 1)
                {
                    string dayOfWeek = GetDateName();
                    Console.WriteLine(dayOfWeek);
                    break;
                }

                int daysFromNow = DaysFromNow();
                Console.WriteLine(daysFromNow);
                break;
            }

            Console.WriteLine("Некорректный ввод!\nВведите ещё раз: ");
        }
    }

}