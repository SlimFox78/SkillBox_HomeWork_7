using Lib;
using Lib.Infrastructure;
using Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    class Application
    {
        static int id = 1000;
        static Notepad notepad = new Notepad(Repository.GetRepository());
        public static void Start()
        {
            Menu();
        }
        static Note GetNote()
        {
            Note note = new Note();
            note.Id = id++;
            Console.Write("Заголовк: ");
            note.Titel = Console.ReadLine();

            Console.Write("Имя: ");
            note.FirstName = Console.ReadLine();

            DateTime dt = new DateTime();
            bool r = false;
            do
            {
                Console.Write("Дата: ");
                r = DateTime.TryParse(Console.ReadLine(), out dt); 
            }
            while (!r);
            
            note.Date = dt;

            Console.Write("Текст: ");
            note.Text = Console.ReadLine();


            return note;
        }

        static int GetIndex()
        {
            int index;
            bool r = false;
            do
            {
                Console.Write("Индекс: ");
                r = int.TryParse(Console.ReadLine(), out index);
            }
            while (!r);
            
            return index;
        }
        static void Menu()
        {
            while(true)
            {
                Console.Write(@"Что делать ? 1 Добавить  2 Удалить 3 Показать 4 Импорт 5 Сортировка 6 Сохранить 7 Выход ");
                string user = Console.ReadLine();
                switch(user)
                {
                    case "1": notepad.Add(GetNote()); break;
                    case "2": notepad.Remove(GetIndex()); break;
                    case "3": Console.WriteLine(notepad.Print()); break;
                    case "4": break;
                    case "5": notepad.SortByDate(); break;
                    case "6": new DataSaver(notepad.Notes).Save(GetPath()); break;
                    case "7": break;
                    default: Console.WriteLine("Угу, так и сделаем"); break;
                }
            }          
        }
        static string GetPath()
        {
            string path = string.Empty;
            do
            {
                Console.Write("Имя файла: ");
                path = Console.ReadLine();
                bool f = true;
                for (int i = 0; i < path.Length; i++)
                {                    
                    if (Char.IsLetterOrDigit(path[i]))
                    {
                        f = false;
                        break;
                    }   
                }
                if (f) break;

            } while (true);

            return $"{path}.txt";
        }
    }
}
