using System;
using System.Collections.Generic;

class Note
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public DateTime Deadline { get; set; }
}

class Program
{
    static List<Note> notes = new List<Note>();

    static int selectedNoteIndex = 0;

    static void Main(string[] args)
    {
        
        notes.Add(new Note
        {
            Title = "Пойти в МПТ",
            Description = "Показать код Софии Алексеевне ",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 13)
        });

        notes.Add(new Note
        {
            Title = "Закончить 1 курс",
            Description = "Окончить 1 курс на 5",
            Date = new DateTime(2023, 9, 1),
            Deadline = new DateTime(2024, 7, 1)
        });

        notes.Add(new Note
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

        for (int i = 0; i < notes.Count; i++)
        {
            if (i == selectedNoteIndex)
                Console.Write("-> ");
            else
                Console.Write("   ");

            Console.WriteLine(notes[i].Title);
        }
    }

    static void ShowNoteDetails()
    {
        Console.Clear();
        Note selectedNote = notes[selectedNoteIndex];

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
        if (selectedNoteIndex >= notes.Count)
            selectedNoteIndex = 0;
    }

    static void MoveToPreviousNote()
    {
        selectedNoteIndex--;
        if (selectedNoteIndex < 0)
            selectedNoteIndex = notes.Count - 1;
    }
}