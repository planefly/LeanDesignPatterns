using System;
using System.Threading;

namespace MementoPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Gamer gamer = new Gamer(100);
            Memento memento = gamer.CreateMemento();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("====" + i);
                Console.WriteLine("当前状态：" + gamer);

                gamer.Bet();

                Console.WriteLine($"所支持有的金钱为 {gamer.GetMoney()} 元。");

                if (gamer.GetMoney() > memento.GetMoney())
                {
                    Console.WriteLine("（所持金钱增加了许多，因此保存游戏的当前状态）");
                    memento = gamer.CreateMemento();
                }
                else if (gamer.GetMoney() < memento.GetMoney() / 2)
                {
                    Console.WriteLine("（所持金钱减少了许多，因此将游戏恢复至之前的状态）");
                    gamer.RestoreMemento(memento);
                }

                Thread.Sleep(1000);
                Console.WriteLine();
            }
        }
    }
}
