namespace AdapterPattern.DeputeMethod
{
    internal class PrintBanner : Print
    {
        // 将 Banner 委托（托付）给 PrintBanner 处理
        private readonly Banner _banner;

        public PrintBanner(string str)
        {
            _banner = new Banner(str);
        }

        public override void PrintStrong()
        {
            _banner.ShowWithParen();
        }

        public override void PrintWeak()
        {
            _banner.ShowWithAster();
        }
    }
}
