using System.IO;

namespace FacadePattern
{
    public class HtmlWriter
    {
        private readonly StreamWriter _writer;

        public HtmlWriter(StreamWriter writer)
        {
            _writer = writer;
        }

        public void Title(string title)
        {
            _writer.Write("<html>");
            _writer.Write("<head>");
            _writer.Write("<title>" + title + "</title>");
            _writer.Write("</head>");
            _writer.Write("<body>\n");
            _writer.Write("<h1>" + title + "</h1>\n");
        }

        public void Paragraph(string msg)
        {
            _writer.Write($"<p>{msg}</p>\n");
        }

        public void Link(string href, string caption)
        {
            Paragraph($"<a href=\"{href}\">{caption}</a>");
        }

        public void MailTo(string mailAddr, string userName)
        {
            Link("mailto:" + mailAddr, userName);
        }

        public void Close()
        {
            _writer.Write("</body>");
            _writer.Write("</html>\n");
            _writer.Close();
        }
    }
}
