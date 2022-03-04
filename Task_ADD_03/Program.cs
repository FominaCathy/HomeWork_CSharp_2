// Задача 3. Иван в январе года открыл счет в банке, вложив 1000 руб. 
// Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
// Определить размер депозита через n месяцев.

class Program
{
    static void Main(string[] args) 
    {
        double summDepozit = 1000;
        Console.Write("Введите количество месяцев N: ");
        int nums = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nums; i++) 
            summDepozit = summDepozit * 1.015;

        Console.Write("Сумма на депозите через " + nums +" месяцев: " + string.Format("{0:f}", summDepozit) + " руб");
    }
}



