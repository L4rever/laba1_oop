using laba1.Task2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Task2
{
    public abstract class DateTimeDecorator : IDateTimePrinter
    {
        protected readonly IDateTimePrinter _inner;

        protected DateTimeDecorator(IDateTimePrinter inner)
        {
            _inner = inner;
        }

        public abstract void PrintCurrentDateTime();
    }
}
