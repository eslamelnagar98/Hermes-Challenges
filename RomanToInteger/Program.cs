using System;
using System.Collections.Generic;
using System.Linq;

namespace RomanToInteger
{
    class Program
    {
        public static Dictionary<char, int> romanNumberDictionary = new Dictionary<char, int>
        {
            {'I',1 },
            {'V',5 },
            {'X',10 },
            {'L',50 },
            {'C',100 },
            {'D',500 },
            {'M',1000 }
        };
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IV"));
            Console.WriteLine(RomanToInt("III"));
            Console.WriteLine(RomanToInt("XLIX"));
            Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }

        static int RomanToInt(string romanNumber)
        {

            var decimalNumbers = 0;
            var lastElementAppear = 0;
            foreach (var item in romanNumber)
            {
                romanNumberDictionary.TryGetValue(item, out int number);
                if ((lastElementAppear != 0) && (number > lastElementAppear))
                {
                    decimalNumbers -= lastElementAppear;
                    number -= lastElementAppear;
                    decimalNumbers += number;
                }
                else
                {
                    decimalNumbers += number;
                    lastElementAppear = number;
                }
            }

            return decimalNumbers;
        }
    }
}
