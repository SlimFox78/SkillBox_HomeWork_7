using Lib;
using Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7
{
    class Application
    {
        public static void Start()
        {
            Notepad notepad = new Notepad(Repository.GetRepository());
            Console.WriteLine(notepad.Print());
        }
    }
}
