using AbstractFactoryPattern.FactoryNs;
using System.Text;

namespace AbstractFactoryPattern.TableFactoryNs
{
    public class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append($"<html><head><title>{Title}</head></title>\n");
            buffer.Append("<body>\n");
            buffer.Append($"<h1>{Title}</h1>\n");

            buffer.Append("<table width=\"80%\" border=\"3\">\n");

            foreach (Item item in Content)
            {
                buffer.Append($"<tr>{item.MakeHTML()}</tr>");
            }

            buffer.Append("</table>\n");
            buffer.Append($"<hr><address>{Author}</address>");
            buffer.Append("</body></html>");

            return buffer.ToString();
        }
    }
}
