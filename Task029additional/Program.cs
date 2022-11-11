// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// Например :
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

class Program
{
    static void Main(string[] args)
    {
    int i;   
        Console.Write ("Введите количество элементов массива:\t");

        int elementsCount = int.Parse(Console.ReadLine());
        
        int [] myArray =  new int[elementsCount];

        for (i = 0; i < elementsCount; i++)
        {
            Console.Write ($"\nВведите элемент массива под индексом {i}:\t ");
            myArray [i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nВывод массива: ");

        for (i = 0; i < elementsCount; i++)
        {
            Console.WriteLine ( myArray [i]);
        }
        
        Console.ReadLine();
    }
}
