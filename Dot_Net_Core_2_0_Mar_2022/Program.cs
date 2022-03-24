using System;
using System.IO;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Xml.Serialization;
using System.Text;

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


            /*
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

            */

            /*
            var t1 = Tuple.Create(101, "Mark Smith", "mark.smith@gmail.com");
            Console.WriteLine( $"{ nameof(t1) } : {t1.Item1} {t1.Item2} {t1.Item3}" );
            Console.WriteLine( t1.ToString() );

            (double, int) t2 = (3.14, 12);
            Console.WriteLine( $"{t2.Item1} {t2.Item2}" );

            (int id, string fullName, string email) t3 = (102, "Tracy Doe", "tracy@gmail.com");
            Console.WriteLine(t3.ToString());

            int id = 103; string fullName = "Lucy"; string email = "lucy@gmail.com";
            t3 = (id, fullName, email);

            Console.WriteLine( $"{t3.id} {t3.fullName} {t3.email}" );

            (int a, int b) l = (15, 100);
            (int a, int b) r = (5, 100);

            Console.WriteLine( l == r );
            */

            /*
            string path = @"d:\tmp\file1.txt";
            Console.WriteLine( $"exists = { File.Exists(path) }" );

            string fileName = Path.GetFileName(path);
            Console.WriteLine($"file name is {fileName}");

            string fileExt = Path.GetExtension(path);
            Console.WriteLine($"ext is {fileExt}");

            string fileNameWithoutExt = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine($"fileNameWithoutExt is {fileNameWithoutExt}");

            string root = Path.GetPathRoot(path);
            Console.WriteLine($"root is {root}");

            string dirName = Path.GetDirectoryName(path);
            Console.WriteLine($"dir name is {dirName}");

            string[] pathArr = { "c:", "Mar_2022", "dot net 2.0", "examples", "content", "file2.cs" };
            string path2 = Path.Combine(pathArr);
            Console.WriteLine($"path2 is {path2}");

            Console.WriteLine("====================================");

            for (int i = 0; i < 10; ++i)
            {
                string randomName = Path.GetTempFileName();
                string tempPath = Path.GetTempPath();
                Console.WriteLine( Path.Combine( tempPath, randomName));
            }
            */

            // Wen, Mar 23
            /*
            string path = @"d:\tmp\file1.txt";

            // string content = "One\nTwo\nThree";
            // WriteToFile(path, content);
            
            
            string json = ReadFromFile(path);

            Top obj = JsonSerializer.Deserialize<Top>(json);
            // obj.PrintInfo();
            // Console.WriteLine(res);
            var xmlSerializer = new XmlSerializer(typeof(Top));

            string xmlFile = "data.xml";
            
            using (FileStream stream = File.Create(xmlFile))
            {
                xmlSerializer.Serialize(stream, obj);
            }

            string path2 = "data2.xml";
            ToXmlFile(obj, path2);

            string xmlContent = File.ReadAllText("XMLFile1.xml");
            Top obj2 = FromXmlFile<Top>(xmlContent);

            obj2.PrintInfo();
            */

            // Thur 24

            //string secretKey = Protector.GenerateSecretKey();
            // Console.WriteLine(secretKey);
            string sk = "NoDHJSW?35ZMn?8J=fK?aN_PtMZN4=cp";

            string card = "1234-5678-9012-3456";
            string encriptedCard = Protector.EncryptString(sk, card);

            Console.WriteLine($"Encrypted card number is {encriptedCard}");
            Console.WriteLine($"Decrypted card number is { Protector.DecryptString(sk, encriptedCard)}");



            string password = "Admin1234";
            string passwordMD5 = Protector.toMD5(password);
            string passwordSaltAndHashed = Protector.SaltAndHash(password);

            Console.WriteLine(passwordMD5);
            Console.WriteLine(passwordSaltAndHashed);

            if (Protector.SaltAndHash("Hach2022") == passwordSaltAndHashed)
            {
                Console.WriteLine("Yes, you can see our information");
            }
            else
            {
                Console.WriteLine("Access denied");
            }
        }

        public static T FromXmlFile<T>(string xml)
        {
            using (StringReader sr = new StringReader(xml))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));

                return (T)xmls.Deserialize(sr);
            }
        }

        public static void ToXmlFile<T>(T obj, string path)
        {
            using (StringWriter sw = new StringWriter(new StringBuilder()))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                xmls.Serialize(sw, obj);
                File.WriteAllText(path, sw.ToString());
            }
        }

        public static void WriteToFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static string ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            return "File not found";
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
