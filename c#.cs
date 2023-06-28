using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
       while (true)
        {
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            if (CheckPassword(password))
            {
                Console.WriteLine("Пароль верный");
                break;
            }
            else
            {
                Console.WriteLine("Пароль неверный, попробуйте еще раз ");

            }
       }
    }

    static bool CheckPassword(string password)
    {
        if (password.Length < 8 || password.Length > 20)
        {
            return false;
        }
        if (!Regex.IsMatch(password, @"\d"))
        {
            return false;
        }
        if (!Regex.IsMatch(password, @"[A-Z]"))
        {
            return false;
        }
        if (!Regex.IsMatch(password, @"[a-z]"))
        {
            return false;
        }
        if (!Regex.IsMatch(password, @"[a-zA-Z0-9]"))
        {
            return false;
        }
        return false;
    }
}
