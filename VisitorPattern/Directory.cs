using System.Collections;

namespace VisitorPattern
{
    public class Directory : Entry
    {
        private readonly string _name;
        public ArrayList _dir = new ArrayList();

        public Directory(string name)
        {
            _name = name;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            int size = 0;
            foreach (Entry entry in _dir)
            {
                size += entry.GetSize();
            }

            return size;
        }

        public override Entry Add(Entry entry)
        {
            _dir.Add(entry);
            return this;
        }

        public override IEnumerator GetEnumerator()
        {
            foreach (Entry entry in _dir)
            {
                yield return entry;
            }
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }

    }
}
