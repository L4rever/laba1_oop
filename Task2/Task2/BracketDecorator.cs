using laba1.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Task2
{
    public class BracketDecorator : DateTimeDecorator
    {
        public BracketDecorator(IDateTimePrinter inner) : base(inner) { }

        public override void PrintCurrentDateTime()
        {
            Console.Write("[[ ");
            _inner.PrintCurrentDateTime();
            Console.WriteLine(" ]]");
        }
    }
}
