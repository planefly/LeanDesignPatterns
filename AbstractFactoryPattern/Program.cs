using AbstractFactoryPattern.FactoryNs;

namespace AbstractFactoryPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Factory factory = Factory.GetFactory("AbstractFactoryPattern.ListFactoryNs.ListFactory");
            // As:
            //Factory factory = new ListFactoryNs.ListFactory();

            Factory factory = new TableFactoryNs.TableFactory();

            Link people = factory.CreateLink(" 人民日报 ", "htttp://www.people.com.cn/");
            Link gmw = factory.CreateLink(" 光明日报 ", "htttp://www.gmw.com/");

            Link us_yahoo = factory.CreateLink(" Yahoo! ", "htttp://www.yahoo.com/");
            Link jp_yahoo = factory.CreateLink(" Yahoo! Japan", "htttp://www.yahoo.co.jp/");
            Link excite = factory.CreateLink(" Excite ", "htttp://www.excite.com/");
            Link google = factory.CreateLink(" Google ", "htttp://www.google.com/");

            Tray trayNews = factory.CreateTray(" 日报 ");
            trayNews.Add(people);
            trayNews.Add(gmw);

            Tray trayYahoo = factory.CreateTray("Yahoo!");
            trayYahoo.Add(us_yahoo);
            trayYahoo.Add(jp_yahoo);

            Tray traySearch = factory.CreateTray(" 搜索引擎 ");
            traySearch.Add(trayYahoo);
            traySearch.Add(excite);
            traySearch.Add(google);

            Page page = factory.CreatePage("LinkPage", " 小明 ");
            page.Add(trayNews);
            page.Add(traySearch);

            page.Output();
        }
    }
}
