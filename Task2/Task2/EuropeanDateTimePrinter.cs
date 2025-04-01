using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.Task2
{
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public void PrintCurrentDateTime()
        {
            string formatted = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            Console.WriteLine("Европейский стиль: " + formatted);
        }
    }
}
