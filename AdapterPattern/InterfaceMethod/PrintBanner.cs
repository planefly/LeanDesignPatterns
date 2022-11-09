namespace AdapterPattern.InterfaceMethod
{
    internal class PrintBanner : Banner, Print
    {
        public PrintBanner(string str) : base(str)
        {
        }

        public void PrintStrong()
        {
            ShowWithParen();
        }

        public void PrintWeak()
        {
            ShowWithAster();
        }
    }
}
