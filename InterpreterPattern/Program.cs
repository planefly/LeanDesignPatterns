using System;
using System.IO;

namespace InterpreterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var reader = new StreamReader("program.txt");

            string text;
            while ((text = reader.ReadLine()) != null)
            {
                Console.WriteLine($"text = \"{text}\"");
                Node node = new ProgramNode();
                node.Parse(new Context(text));
                Console.WriteLine($"node = {node}");
                Console.WriteLine();
            }

            reader.Close();
        }
    }
}
