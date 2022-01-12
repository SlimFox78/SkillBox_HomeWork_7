using System;
using Lib.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public string FirstName { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public override string ToString()
        {
            return $"{Id,4} {Titel, 12} {FirstName,12} {Date,20} {Text}";
        }
    }
}
