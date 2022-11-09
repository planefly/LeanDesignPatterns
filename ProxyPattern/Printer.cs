using System;
using System.Threading;

namespace ProxyPattern
{
    public class Printer : Printable
    {
        private string _name;

        public Printer()
        {
            HeavyJob("正在生成Printer实例");
        }

        public Printer(string name)
        {
            _name = name;
            HeavyJob($"正在生成Printer实例（{name}）");
        }

        public void SetPrinterName(string name)
        {
            _name = name;
        }

        public string GetPrinterName()
        {
            return _name;
        }

        public void Print(string str)
        {
            Console.WriteLine($"==={_name}===");
            Console.WriteLine(str);
        }

        private void HeavyJob(string msg)
        {
            Console.Write(msg);
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("结束。");
        }
    }
}
