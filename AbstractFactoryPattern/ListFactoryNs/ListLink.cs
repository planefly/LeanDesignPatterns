using AbstractFactoryPattern.FactoryNs;

namespace AbstractFactoryPattern.ListFactoryNs
{
    public class ListLink : Link
    {
        public ListLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHTML()
        {
            return $"  <li><a href=\"{Url}\">{Capation}</a></li>\n";
        }
    }
}
