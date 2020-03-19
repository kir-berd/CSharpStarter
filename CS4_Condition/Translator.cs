using System;
using System.Collections.Generic;
using System.Text;

namespace CS4_Condition
{
    class Translator
    {
        static public void Translate()
        {
            string input = Console.ReadLine();
            string output;

            switch(input)
            {
                case "солнечно":
                    output = "sunny";
                    break;
                case "жара":
                    output = "heat";
                    break;
                case "холодно":
                    output = "cold";
                    break;
                case "ветер":
                    output = "wind";
                    break;
                default:
                    output = "Такого слова нет";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
