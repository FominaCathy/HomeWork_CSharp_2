// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
class Program
{
    static void Main(string[] args) 
    {
        Console.Write("Введите номер дня недели: ");
        int number = int.Parse(Console.ReadLine());

        switch (number)
        {
            case < 6: 
                Console.Write("Данный день недели - будни");
                break;
            case >7 :
                Console.Write("Дня недели с таким номером нет");
                break;
            default: 
                Console.Write("Данный день недели - выходной");
                break;

        }
    }
}
