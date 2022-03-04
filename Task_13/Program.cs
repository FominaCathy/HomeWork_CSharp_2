// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите число: ");
        string number = Console.ReadLine();
        if (number.Length < 3)
            Console.Write("Третьей цифры (слева) в заданном числе нет");
        else
            Console.Write("Третья цифра (слева) в заданном числе = "+ number[2]);
    }
}
