using AbstractFactoryPattern.FactoryNs;
using System.Text;

namespace AbstractFactoryPattern.ListFactoryNs
{
    public class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHTML()
        {
            StringBuilder buffer = new StringBuilder();
            buffer.Append("<li>\n");
            buffer.Append(Capation + "\n");
            buffer.Append("<ul>\n");

            foreach (Item tray in Trays)
            {
                buffer.Append(tray.MakeHTML());
            }

            buffer.Append("</ul>\n");
            buffer.Append("</li>\n");

            return buffer.ToString();
        }
    }
}
