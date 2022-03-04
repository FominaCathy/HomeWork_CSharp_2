// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите трехзначное число: ");
        string number = Console.ReadLine();
        while (number.Length != 3)
        {
            Console.Write("Введите трехзначное число: ");
            number = Console.ReadLine();
        }

        number = "" + number[2] + number[1] + number[0];        
        Console.Write("Перевернутое число: "+ int.Parse(number));
    }
}