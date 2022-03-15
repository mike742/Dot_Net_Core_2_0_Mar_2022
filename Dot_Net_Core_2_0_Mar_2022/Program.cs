using System;
using System.Text.RegularExpressions;

namespace Dot_Net_Core_2_0_Mar_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintIsValid("aaaa", "^a{5}$");
            // PrintIsValid("nnn", "^n{3}$");
            // PrintIsValid("Books.123", "^[a-zA-Z0-9_/.]{4,17}$");
            // PrintIsValid("123", @"^\d{3}$");
            // PrintIsValid("john_12345", @"^\w{5,}$");
            // \d == [0-9]
            // \w == [0-9A-Za-z_]
            // \s
            // PrintIsValid("    ", @"^\s{3}$");
            // \t 
            // PrintIsValid("  ", @"^\t$");
            // {1,} == +
            // {0,} == ?
            // PrintIsValid("hello world", @"^[a-z]+$");
            // PrintIsValid("cccccccccat", @"^c*at$");
            // PrintIsValid("sat", @"^s(e|i)t$"); // set or sit

            ConsoleKeyInfo cki = Console.ReadKey(true);
            if (cki.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("You have pressed  Escape");
            }
            if (cki.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("You have pressed  Enter");
            }
        }

        static void PrintIsValid(string value, string re)
        {
            Regex rx = new Regex(@$"{re}");
            Console.WriteLine( $" { value } and { re } is {rx.IsMatch(value)} " );
        }
    }
}
