﻿namespace VisitorPattern
{
    public class File : Entry
    {
        private readonly string _name;
        private readonly int _size;

        public File(string name, int size)
        {
            _name = name;
            _size = size;
        }

        public override string GetName()
        {
            return _name;
        }

        public override int GetSize()
        {
            return _size;
        }

        public override void Accept(Visitor v)
        {
            v.Visit(this);
        }
    }
}
