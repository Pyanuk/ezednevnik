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
            Description = "Окончить 1 курс на 4 и 5",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 12)
        });

        ramils.Add(new ramil
        {
            Title = "Купить сиги",
            Description = "Ебаный винстон синий",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 12)
        });

        ramils.Add(new ramil
        {
            Title = "Пойти по хавать",
            Description = "Схавать пэрэмэч(татарское нацональное блюдо)",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 12)
        });
        ramils.Add(new ramil
        {
            Title = "Купить права",
            Description = "Батя договориться за 40к",
            Date = new DateTime(2023, 10, 12),
            Deadline = new DateTime(2023, 10, 12)
        });

        while (true)
        {
            Console.Clear(); 
            var currentNote = ramils[selectedNoteIndex];
            Console.WriteLine(":-)");
            Console.WriteLine("Ежедневник");
            Console.WriteLine($"Заголовок: {currentNote.Title}");
            Console.WriteLine($"Описание: {currentNote.Description}");
            Console.WriteLine($"Дата: {currentNote.Date}");
            Console.WriteLine($"Дедлайн: {currentNote.Deadline}");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.LeftArrow)
            {
                MoveToPreviousNote();
            }
            else if (key == ConsoleKey.RightArrow)
            {
                MoveToNextNote();
            }
        }
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

    internal class ramil
    {
        public string Description { get; internal set; }
        public string Title { get; internal set; }
        public DateTime Date { get; internal set; }
        public DateTime Deadline { get; internal set; }
    }
}
