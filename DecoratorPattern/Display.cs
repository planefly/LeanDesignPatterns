using System;

namespace DecoratorPattern
{
    public abstract class Display
    {
        public abstract int GetColumns();
        public abstract int GetRows();
        public abstract string GetRowText(int row);
        public void Show()
        {
            int count = GetRows();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(GetRowText(i));
            }
        }
    }
}
