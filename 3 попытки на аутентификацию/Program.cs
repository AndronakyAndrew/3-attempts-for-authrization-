using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в программу!");
        Console.WriteLine("Введите логин:");
        string login = Console.ReadLine();
        Console.WriteLine("Введите пароль:");
        string password = Console.ReadLine();

        int attempt = 0;

        while (attempt < 3)
        {
            if (login == "admin" && password == "12345")
            {
                Console.WriteLine("Вы успешно авторизовались!");
                break;
            }
            else
            {
                Console.WriteLine("Вы ввели неверный логин или пароль!");
                attempt++;
                Console.WriteLine($"Осталось {3 - attempt} попыток!");
                Console.WriteLine("Введите логин:");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
            }
        }
    }
}