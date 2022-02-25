Console.WriteLine("=======Задача № 4=======");
Console.WriteLine("Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
try
{
    Console.Write("Введите число a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число c: ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write("a = " + a + " b = " + b + " c = " + c + " -> max = ");
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    Console.WriteLine(max);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
