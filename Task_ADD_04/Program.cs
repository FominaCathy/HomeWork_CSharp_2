// Задача 4. Дано натуральное число, в котором все цифры различны. 
// Определить, какая цифра расположена в нем левее: максимальная или минимальная.

class Program
{
    static void Main(string[] args) 
    {
        int i; 
        int indMax = 0;
        int indMin = 0;

        Console.Write("Введите натуральное число N: ");
        string nums = Console.ReadLine();

        for (i =0; i < nums.Length; i++)
        {
            if (nums[i]>nums[indMax]) indMax = i;
            if (nums[i]<nums[indMin]) indMin = i;
        }

         if (indMax > indMin)
            Console.WriteLine("минимальная цифра расположена левее" );
         else 
            Console.WriteLine("максимальная цифра расположена левее" );


    }
}



