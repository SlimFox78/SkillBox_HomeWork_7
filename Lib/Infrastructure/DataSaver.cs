using Lib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Infrastructure
{
    public class DataSaver
    {
        private Note[] notes;

        public DataSaver(params Note[] notes)
        {
            this.notes = notes;
        }

        public void Save(string path)
        {
            StreamWriter sw = new StreamWriter(path);
            foreach (var item in notes)
            {
                sw.WriteLine(item.Id);
                sw.WriteLine(item.Titel);
                sw.WriteLine(item.FirstName);
                sw.WriteLine(item.Date);
                sw.WriteLine(item.Text);
                sw.WriteLine();

            }
            sw.Close();
        }

    }
}
