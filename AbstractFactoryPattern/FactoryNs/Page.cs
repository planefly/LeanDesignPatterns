using System;
using System.Collections.Generic;
using System.IO;

namespace AbstractFactoryPattern.FactoryNs
{
    public abstract class Page
    {
        protected string Title;
        protected string Author;
        protected List<Item> Content = new List<Item>();

        public Page(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Add(Item item)
        {
            Content.Add(item);
        }

        public void Output()
        {
            string fileName = Title + ".html";
            StreamWriter writer = new StreamWriter(fileName);
            writer.Write(MakeHTML());
            writer.Close();
            Console.WriteLine($"{fileName} 编写完成。");
        }

        public abstract string MakeHTML();
    }
}
