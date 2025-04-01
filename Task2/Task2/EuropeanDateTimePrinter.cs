using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.Task2
{
    public class EuropeanDateTimePrinter : IDateTimePrinter
    {
        public void PrintCurrentDateTime()
        {
            var sb = new StringBuilder();
            var now = DateTime.Now;
            string formatted = now.ToString("dd.MM.yyyy HH:mm", CultureInfo.GetCultureInfo("fr-FR"));
            sb.Append(formatted);
            Console.WriteLine("Европейский стиль: " + sb.ToString());
        }
    }
}
