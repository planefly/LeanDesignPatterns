using System;

namespace CompositePattern
{
    public abstract class Entry
    {
        public abstract string GetName();

        public abstract int GetSize();

        public virtual Entry Add(Entry entry)
        {
            throw new Exception("FileTreatmentException");
        }

        public void PrintList()
        {
            PrintList("");
        }

        // 这里不能使用 protected 修饰符，因为 Directory 与 File 不是继承关系，
        // 且 Directory 也不能调用 Entry 中的 abstract 修饰符方法
        internal abstract void PrintList(string prefix);

        public override string ToString()
        {
            return $"{GetName()}({GetSize()})";
        }
    }
}
