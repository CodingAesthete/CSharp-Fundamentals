using System;
using System.Linq;
using System.Text;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] sent = input.Split(@" |").ToArray();
            StringBuilder sentence = new StringBuilder();
            foreach (var item in sent)
            {
                string itemo = item;
                string[] raw = itemo.Split(" ");
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] == "..")
                    {
                        sentence.Append("I");
                    }
                    else if (raw[i] == "--")
                    {
                        sentence.Append("M");
                    }
                    else if (raw[i] == ".-")
                    {
                        sentence.Append("A");
                    }
                    else if (raw[i] == "-...")
                    {
                        sentence.Append("B");
                    }
                    else if (raw[i] == "-.-.")
                    {
                        sentence.Append("C");
                    }
                    else if (raw[i] == "-..")
                    {
                        sentence.Append("D");
                    }
                    else if (raw[i] == ".")
                    {
                        sentence.Append("E");
                    }
                    else if (raw[i] == "..-.")
                    {
                        sentence.Append("F");
                    }
                    else if (raw[i] == "--.")
                    {
                        sentence.Append("G");
                    }
                    else if (raw[i] == "....")
                    {
                        sentence.Append("H");
                    }
                    else if (raw[i] == ".---")
                    {
                        sentence.Append("J");
                    }
                    else if (raw[i] == "-.-")
                    {
                        sentence.Append("K");
                    }
                    else if (raw[i] == ".-..")
                    {
                        sentence.Append("L");
                    }
                    else if (raw[i] == "-.")
                    {
                        sentence.Append("N");
                    }
                    else if (raw[i] == "---")
                    {
                        sentence.Append("O");
                    }
                    else if (raw[i] == ".--.")
                    {
                        sentence.Append("P");
                    }
                    else if (raw[i] == "--.-")
                    {
                        sentence.Append("Q");
                    }
                    else if (raw[i] == ".-.")
                    {
                        sentence.Append("R");
                    }
                    else if (raw[i] == "...")
                    {
                        sentence.Append("S");
                    }
                    else if (raw[i] == "-")
                    {
                        sentence.Append("T");
                    }
                    else if (raw[i] == "..-")
                    {
                        sentence.Append("U");
                    }
                    else if (raw[i] == "...-")
                    {
                        sentence.Append("V");
                    }
                    else if (raw[i] == ".--")
                    {
                        sentence.Append("W");
                    }
                    else if (raw[i] == "-..-")
                    {
                        sentence.Append("X");
                    }
                    else if (raw[i] == "-.--")
                    {
                        sentence.Append("Y");
                    }
                    else if (raw[i] == "--..")
                    {
                        sentence.Append("Z");
                    }
                }
                sentence.Append(" ");
            }
            Console.WriteLine(sentence);
        }
    }
}
