using Lib.Infrastructure;
using Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class Notepad
    {
        string path;
        Col cols;       
        public Notepad(string path)
        {
            this.path = path;
            cols = new Col(String.Empty);
        }
        public Notepad(params Note[] args)
        {
            cols = new Col(args);
        }
        public void Add(Note note)
        {
            cols.Add(note);
        }
        public void Remove(int index)
        {
            cols.Remove(index);
        }
        public void Edit(int index, Note note)
        {
            cols.Edit(index, note); 
        }
        public string Print()
        {
            StringBuilder t = new StringBuilder();
            int count = cols.Count;           
            for(int i = 0; i < count; i++)
            {
                t.Append($" {cols[i]} \n");
            }
            return t.ToString();
        }
    }
}
