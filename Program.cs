using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace binhexdec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Zde napiš jakékoli číslo z sousav, binary, decimal nebo hexidecimal: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            string number = Console.ReadLine();
            Console.Clear();
            if (IsHex(number))
            {
                if (Regex.IsMatch(number, "^[01]+$") == true)
                {
                    Console.WriteLine("Vaše číslo: " + number);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                    Console.WriteLine("Pokud Decimal");
                    Console.WriteLine("Binary: " + Convert.ToString(Convert.ToInt32(number), 2));
                    Console.WriteLine("Hexidecimal: " + Convert.ToString(Convert.ToInt32(number), 16).ToUpper());
                    Console.WriteLine();
                    Console.WriteLine("Pokud Binary");
                    Console.WriteLine("Decimal: " + Convert.ToInt32("1001101", 2));
                    Console.WriteLine("Hexidecimal: " + Convert.ToString(Convert.ToInt32("1001101", 2), 16).ToUpper());
                }
                else
                {
                    Console.WriteLine("Vaše číslo: " + number);
                    Console.ForegroundColor = ConsoleColor.Green;
                    //Napsal Libor Šenar
                    Console.WriteLine();
                    Console.WriteLine("Binary: " + Convert.ToString(Convert.ToInt32(number), 2));
                    Console.WriteLine("Hexidecimal: " + Convert.ToString(Convert.ToInt32(number), 16).ToUpper());
                }
            }
            else
            {
                Console.WriteLine("Vaše číslo: " + number.ToUpper());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine("Binary: " + Convert.ToString(Convert.ToInt32(number.ToUpper(), 16), 2));
                Console.WriteLine("Decimal: " + Convert.ToString(Convert.ToInt32(number.ToUpper(), 16), 10));
            }
            Console.ReadKey();
        }
        static bool IsHex(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
