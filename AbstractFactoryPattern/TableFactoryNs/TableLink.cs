using AbstractFactoryPattern.FactoryNs;

namespace AbstractFactoryPattern.TableFactoryNs
{
    public class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $"<td><a href=\"{Url}\">{Capation}</a></td>\n";
        }
    }
}
