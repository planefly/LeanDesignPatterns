using System.IO;

namespace BuilderPattern
{
    public class HTMLBuilder : Builder
    {
        private string _fileName;

        private StreamWriter _writer;

        public override void MakeTitle(string title)
        {
            _fileName = title + ".html";
            _writer = new StreamWriter(_fileName, false);
            _writer.WriteLine($"<html><head><title>{title}</title></head><body>");
            _writer.WriteLine($"<h1>{title}</h1>");
        }

        public override void MakeString(string str)
        {
            _writer.WriteLine($"<p>{str}</p>");
        }

        public override void MakeItems(string[] items)
        {
            _writer.WriteLine("<ul>");
            for (int i = 0; i < items.Length; i++)
            {
                _writer.WriteLine($"<li>{items[i]}</li>");
            }

            _writer.WriteLine("</ul>");
        }

        public override void Close()
        {
            _writer.WriteLine("</body></html>");
            _writer.Close();
        }

        public string GetResult()
        {
            return _fileName;
        }
    }
}
