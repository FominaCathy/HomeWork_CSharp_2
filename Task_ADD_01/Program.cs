//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

class Program
{
    static void Main(string[] args) 
    {
    int a, b, c;
        EnterVar ();
        while ((a<=0)|(b<=0)|(c<=0)) 
        {
        Console.WriteLine("Стороны треугольника заданы некорректно. Повторите ввод");
        EnterVar ();
        }

        if ((a==b)|(a==c)|(b==c)) 
            Console.Write("Треугольник со сторонами: "+ a + ", " + b + ", " + c + ", " + "является равнобедернным");
        else 
            Console.Write("Треугольник со сторонами: "+ a + ", " + b + ", " + c + ", " + " НЕ является равнобедернным");

    
     void EnterVar ()
        {
        Console.Write("Введите номер сторону треугольника а: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Введите номер сторону треугольника b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Введите номер сторону треугольника c: ");
        c = int.Parse(Console.ReadLine());
        }
    }    
}    
