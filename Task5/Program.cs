// Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N. (не включая N)
//5 -> 2, 4
//8 -> 2, 4, 6
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int m = int.Parse(Console.ReadLine());
        for (int i = n; i <= m; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
        Console.ReadKey();
    }
}