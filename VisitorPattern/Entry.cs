using System;
using System.Collections;

namespace VisitorPattern
{
    public abstract class Entry : Element, IEnumerable
    {
        public abstract string GetName();

        public abstract int GetSize();

        public virtual Entry Add(Entry entry)
        {
            throw new Exception("FileTreatmentException");
        }

        public virtual IEnumerator GetEnumerator()
        {
            throw new Exception("FileTreatmentException");
        }

        public abstract void Accept(Visitor v);

        public override string ToString()
        {
            return $"{GetName()}({GetSize()})";
        }
    }
}
