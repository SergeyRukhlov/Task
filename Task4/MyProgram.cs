namespace Lessons
{

        // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        //4 -> да
        //3 -> нет
        //7 -> нет
        class Program
        {
            static void Main(string[] args)
            {
                int a;
                
                Console.WriteLine("Введите число");

                a = int.Parse(Console.ReadLine());
                if(a % 2 == 0)
                {
                Console.WriteLine("Четное число");
                }
                 else if(a % 2 == 1)
                {
                Console.WriteLine("Нечетное число");
                }


            }
        }
    }
