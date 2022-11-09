using System;
using System.Collections;

namespace CompositePattern
{
    public class Directory : Entry
    {
        private readonly string _name;

        private readonly ArrayList _directorys = new ArrayList();

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
            foreach (Entry entry in _directorys)
            {
                size += entry.GetSize();
            }

            return size;
        }

        public override Entry Add(Entry entry)
        {
            _directorys.Add(entry);
            return this;
        }

        internal override void PrintList(string prefix)
        {
            Console.WriteLine($"{prefix}/{this}");

            foreach (Entry entry in _directorys)
            {
                entry.PrintList($"{prefix}/{_name}");
            }
        }

    }
}
