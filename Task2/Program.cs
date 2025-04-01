using laba1.Task2;
using Task2.Task2;

IDateTimePrinter printer = new AmericanDateTimePrinter();

printer = new RandomSymbolDecorator(printer);
printer = new BracketDecorator(printer);

printer.PrintCurrentDateTime();