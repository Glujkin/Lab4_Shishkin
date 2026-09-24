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
                    if (choice == "1") Console.WriteLine("\n>> ФИО: Шишикин Тимофей\n");
            else if (choice == "2") Console.WriteLine("\n>> Группа: ИСП-231\n");
            else if (choice == "3") Console.WriteLine("\n>> Дата: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "\n");
            else if (choice == "4") { Console.WriteLine("\nВыход."); break; }
            else Console.WriteLine("\n! Неверный ввод.\n");
        
        }
    }
}