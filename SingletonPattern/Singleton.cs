using System;

namespace SingletonPattern
{
    public class Singleton
    {
        private static readonly Singleton _singleton = new Singleton();

        private Singleton()
        {
            Console.WriteLine("生成了一个实例。");
        }

        public static Singleton GetInstance()
        {
            return _singleton;
        }
    }
}
