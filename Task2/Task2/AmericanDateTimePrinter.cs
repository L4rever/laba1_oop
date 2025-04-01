using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1.Task2
{
    public class AmericanDateTimePrinter : IDateTimePrinter
    {
        public void PrintCurrentDateTime()
        {
            var sb = new StringBuilder();
            var now = DateTime.Now;
            string formatted = now.ToString("MM/dd/yyyy hh:mm tt", CultureInfo.GetCultureInfo("en-US"));
            sb.Append(formatted);
            Console.WriteLine("Американский стиль: " + sb.ToString());
        }
    }
}
