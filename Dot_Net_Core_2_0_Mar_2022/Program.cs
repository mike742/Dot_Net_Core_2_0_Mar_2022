using System;
using System.Numerics;
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

            //ConsoleKeyInfo cki = Console.ReadKey(true);
            //if (cki.Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine("You have pressed  Escape");
            //}
            //if (cki.Key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("You have pressed  Enter");
            //}

            //BigInteger big1 = new BigInteger(double.MaxValue);
            //BigInteger big2 = new BigInteger(double.MaxValue);

            //BigInteger res = BigInteger.Add(big1, big2);

            //Console.WriteLine(res.ToString());

            var big = BigInteger.Parse("123456789");

            string strBig = big.ToString("N0");
            Console.WriteLine(strBig);

            string[] numbersByThree = strBig.Split(',');

            // ThreeDigitsToWords(numbersByThree[0]);
            string result = string.Empty;

            for (int i = 0; i < numbersByThree.Length; ++i)
            {
                if (numbersByThree[i] != "000")
                {
                    result += string.IsNullOrEmpty(result) ? "" : " "; 
                    result += ThreeDigitsToWords(numbersByThree[i]);
                    result += " " + LargeNumberToWord(numbersByThree.Length - i - 1);
                }
            }

            Console.WriteLine($"result = {result}");


            // Extension methods
            string str = "hello extension method!";
            // Console.WriteLine(  StringHelper.FlipFirstLetterCase(str) );

            Console.WriteLine(str.FlipFirstLetterCase());
            // str.FlipFirstLetterCase();
        }

        public static string LargeNumberToWord(int value)
        {
            string[] largeMap = new[] {
            "", "thousand", "million", "billion",
            "trillion", "quadrillion", "quintillion", "sextillion", "septillion", "octillion",
            "nonillion", "decillion", "undecillion", "duodecillion", "tredecillion",
            "Quattuordecillion", "Quindecillion", "Sexdecillion", "Septdecillion",
            "Octodecillion", "Novemdecillion", "Vigintillion"
            };
            return largeMap[value];
        }

        static string ThreeDigitsToWords(string number)
        {
            number = number.PadLeft(3, '0');

            // Console.WriteLine(number);
            string res = string.Empty;

            var unitsMap = new[] {
                "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };
            var tensMap = new[] {
                "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty"
            };
            // 316
            int ind;
            if (number[0] != '0')
            {
                ind = Convert.ToInt32(number[0].ToString());
                res += $"{unitsMap[ind]} hundred"; 
            }

            if (number[1] == '1')
            {
                ind = Convert.ToInt32(number[1].ToString() + number[2].ToString());
                res += $" {unitsMap[ind]} ";
            }
            else
            {
                ind = Convert.ToInt32(number[1].ToString());
                string tens = tensMap[ind];

                ind = Convert.ToInt32(number[2].ToString());
                string afterTen = number[2] == '0' ? "" :
                    unitsMap[ind];

                res += $" {tens} {afterTen}";
            }

            // Console.WriteLine($"res: {res}");
            return res;
        }

        static void PrintIsValid(string value, string re)
        {
            Regex rx = new Regex(@$"{re}");
            Console.WriteLine( $" { value } and { re } is {rx.IsMatch(value)} " );
        }
    }
}
