using AbstractFactoryPattern.FactoryNs;
using System.Text;

namespace AbstractFactoryPattern.TableFactoryNs
{
    public class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<td>");
            buffer.Append("<table width=\"100%\" border=\"1\"><tr>");
            buffer.Append($"<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"{Trays.Count}\"><b>{Capation}</b></td>");
            buffer.Append("</tr>\n");
            buffer.Append("<tr>\n");

            foreach (Item t in Trays)
            {
                buffer.Append(t.MakeHTML());
            }

            buffer.Append("</tr></table>");
            buffer.Append("</td>");

            return buffer.ToString();
        }
    }
}
