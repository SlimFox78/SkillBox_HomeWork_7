using Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Infrastructure
{
   public class Repository
    {
        static Random rand = new Random(); 
        static public Note[] GetRepository()
        {
            int count = rand.Next(10, 15);
            Note[] t = new Note[count];
            for(int i = 0; i < count; i++)
            {
                t[i] = new Note
                {
                    Id = i + 1,
                    Date = DateTime.Now + new TimeSpan(ticks: rand.Next(30 * 24 * 60 * 60, 80 * 24 * 60 * 60)),
                    Titel= $"Заголовок_{i+1}",
                    Text=Guid.NewGuid().ToString(),
                    FirstName=$"Имя_{i+1}",
                };
            }
            return t;
        }
    }
}
