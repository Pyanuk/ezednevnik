using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class ramil
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime Deadline { get; set; }
    }
}
class MPT
{
    static List<ramil> ramils = new List<ramil>();

    static int selectedNoteIndex = 0;

    static void Main(string[] args)
    {

        ramils.Add(new ramil
        {
            Title = "Пойти в МПТ",
            Description = "Показать код Софии Алексеевне ",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 13)
        });

        ramils.Add(new ramil
        {
            Title = "Закончить 1 курс",
            Description = "Окончить 1 курс на 5",
            Date = new DateTime(2023, 9, 1),
            Deadline = new DateTime(2024, 7, 1)
        });

        ramils.Add(new ramil
        {
            Title = "Купить сиги",
            Description = "Ебаный винстон синий",
            Date = new DateTime(2022, 10, 11),
            Deadline = new DateTime(2022, 10, 1)
        });

        while (true)
        {
            Console.Clear();
            ShowMenu();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    MoveToPreviousNote();
                    break;
                case ConsoleKey.RightArrow:
                    MoveToNextNote();
                    break;
                case ConsoleKey.Enter:
                    ShowNoteDetails();
                    break;
                case ConsoleKey.Escape:
                    return;
            }
        }
    }

    static void ShowMenu()
    {
        Console.WriteLine(":-)");
        Console.WriteLine("Ежедневник");

        for (int i = 0; i < ramils.Count; i++)
        {
            if (i == selectedNoteIndex)
                Console.Write("-> ");
            else
                Console.Write("   ");

            Console.WriteLine(ramils[i].Title);
        }
    }

    static void ShowNoteDetails()
    {
        Console.Clear();
        ramil selectedNote = ramils[selectedNoteIndex];

        Console.WriteLine($"Название: {selectedNote.Title}");
        Console.WriteLine($"Описание: {selectedNote.Description}");
        Console.WriteLine($"Дата: {selectedNote.Date.ToShortDateString()}");
        Console.WriteLine($"Крайний срок: {selectedNote.Deadline.ToShortDateString()}\n");

        Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в меню...");
        Console.ReadKey();
    }

    static void MoveToNextNote()
    {
        selectedNoteIndex++;
        if (selectedNoteIndex >= ramils.Count)
            selectedNoteIndex = 0;
    }

    static void MoveToPreviousNote()
    {
        selectedNoteIndex--;
        if (selectedNoteIndex < 0)
            selectedNoteIndex = ramils.Count - 1;
    }
}

internal class ramil
{
    public string Description { get; internal set; }
    public string Title { get; internal set; }
    public DateTime Date { get; internal set; }
    public DateTime Deadline { get; internal set; }
}
