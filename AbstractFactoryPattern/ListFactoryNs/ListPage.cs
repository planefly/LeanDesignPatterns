using AbstractFactoryPattern.FactoryNs;
using System.Text;

namespace AbstractFactoryPattern.ListFactoryNs
{
    public class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{Title}</head></title>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{Title}</h1>\n");
            buffer.Append("<ul>\n");

            foreach (Item item in Content)
            {
                buffer.Append(item.MakeHTML());
            }

            buffer.Append("</ul>\n");
            buffer.Append($"<hr><address>{Author}</address>");
            buffer.Append("</body></html>");

            return buffer.ToString();
        }
    }
}
