// Задача 2. На вход подаются год, номер месяца и день рождения человека, 
// Определить возраст человека на момент 1 февраля 2022 года.

class Program
{
    static void Main(string[] args) 
    {
    
    Console.Write("Введите день рождения: ");
    int day = int.Parse(Console.ReadLine());
    Console.Write("Введите номер месяца рождения: ");
    int month = int.Parse(Console.ReadLine());
    Console.Write("Введите год рождения: ");
    int year = int.Parse(Console.ReadLine());

    if ((month == 1)|((month == 2)&(day == 1))) 
        Console.WriteLine("Возраст = "+ (2022-year));
    else    
        Console.WriteLine("Возраст = "+ (2022-year-1));
    }

}
        
