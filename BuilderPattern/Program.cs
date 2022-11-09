using System;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            {
                TextBuilder builder = new TextBuilder();
                Director director = new Director(builder);

                director.Construct();
                string result = builder.GetResult();
                Console.WriteLine(result);
            }

            {
                HTMLBuilder builder = new HTMLBuilder();
                Director director = new Director(builder);

                director.Construct();
                string result = builder.GetResult();
                Console.WriteLine(result);
            }
        }
    }
}
