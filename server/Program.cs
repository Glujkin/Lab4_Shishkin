using System;
class Program {
    static void Main() {
        Console.WriteLine("Лабораторная работа №4");
        Console.WriteLine("ФИО: Шишкин Тимофей");
        Console.WriteLine("Группа: ИСП-231");
        Console.WriteLine("Дата: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss"));
        Console.WriteLine();
         while (true) {
        Console.WriteLine("--- Меню ---");
        Console.WriteLine("1 - Показать ФИО");
        Console.WriteLine("2 - Показать группу");
        Console.WriteLine("3 - Показать дату");
        Console.WriteLine("4 - Выход");
        Console.Write("Ваш выбор: ");
        string choice = Console.ReadLine();
        }
    }
}