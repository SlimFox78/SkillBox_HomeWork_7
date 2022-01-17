﻿using Lib;
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
                Console.Write("ID: ");
                r = int.TryParse(Console.ReadLine(), out index);
            }
            while (!r);
            
            return index;
        }
        static void Menu()
        {
            while(true)
            {
                Console.Write(@"Что делать ? 1 Добавить  2 Удалить 3 Показать 4 Импорт 5 Выход ");
                string user = Console.ReadLine();
                switch(user)
                {
                    case "1": notepad.Add(GetNote()); break;
                    case "2": break;
                    case "3": Console.WriteLine(notepad.Print()); break;
                    case "4": break;
                    case "5": break;
                    default: Console.WriteLine("Угу, так и сделаем"); break;
                }
            }          
        }
    }
}
