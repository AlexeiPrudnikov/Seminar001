Console.WriteLine("=======Задача № 8=======");
Console.WriteLine("Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
try
{
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 0)
    {
        Console.WriteLine("Число должно быть больше 0!!!");
    }
    else
    {
        Console.Write (n + " -> ");
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write (i + " ");
        }
    }

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
