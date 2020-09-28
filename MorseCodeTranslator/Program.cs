using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCodeTranslator
{
    class Program
    {
        static Dictionary<char, string> _morseTranslator;

        private static void InitialiseDictionary()
        {
            _morseTranslator = new Dictionary<char, string>()
            {
                {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
            };

        }

        private static string GetUserInput()
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                input = input.ToLower();
            }

            return input;
        }

        private static string Translate(string input)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (char ch in input)
            {
                if (_morseTranslator.ContainsKey(ch))
                {
                    sb.Append(_morseTranslator[ch] + " ");
                }
                else if (ch == ' ')
                {
                    sb.Append('/');
                }
                else
                {
                    sb.Append(ch+" ");
                }
            }
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            InitialiseDictionary();

            Console.WriteLine("What is your message:");
            string input = GetUserInput();

            Console.WriteLine("Morse code is: "+ Translate(input));

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
